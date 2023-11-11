﻿using QuizApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for PlayGame.xaml
    /// </summary>
    public partial class PlayGame : UserControl
    {
        private int IndexQuestion = 0;
        private List<QuizData> Quizquestions;
        private int TotalNumberQuestions;
        private Player player = new Player();

        public PlayGame(string filename)
        {
            InitializeComponent();
            Quizquestions = LoadQuestions(filename);
            ShuffleQuestions<QuizData>();
            TotalNumberQuestions = Quizquestions.Count;
            UpdateContent();
        }

        private List<QuizData> LoadQuestions(string filename)
        {
            string path = filename;
            // Create a new StreamReader object to read the contents of the JSON file.
            StreamReader reader = new StreamReader(path);
            // Read the contents of the JSON file into a string variable.
            string json = reader.ReadToEnd();
            // Create a JsonSerializerOptions object to specify the options for deserializing the JSON data.
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            // Deserialize the JSON data into a strongly typed object using the JsonSerializer.Deserialize<T>() method.
            List<QuizData> questions = JsonSerializer.Deserialize<List<QuizData>>(json, options)!;
            reader.Close();
            return questions;
        }

        private void UpdateContent()
        {
            ShuffleAnswers<QuizData>();
            CurrentQuestion.Content = $"{IndexQuestion + 1}/{TotalNumberQuestions} {Quizquestions[IndexQuestion].question}";
            Answer1.Content = $"{Quizquestions[IndexQuestion].Answers[0].Text}";
            Answer2.Content = $"{Quizquestions[IndexQuestion].Answers[1].Text}";
            Answer3.Content = $"{Quizquestions[IndexQuestion].Answers[2].Text}";
            Answer4.Content = $"{Quizquestions[IndexQuestion].Answers[3].Text}";
        }

        private void backBtn(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new QuizMenu();
        }

        private void answer_clicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string text = (string)button.Content;
            var q = Quizquestions[IndexQuestion].Answers.Find(a => a.Text == text)!;
            if (q is not null)
            {
                if (q.Correct == true)
                {
                    player.WriteAnswers++;
                }
                else
                {
                    player.WrongAnswers++;
                }
            }
            if (IndexQuestion < TotalNumberQuestions - 1)
            {
                IndexQuestion++;
                UpdateContent();
            }else
            {
                string message = "Το παιχνίδι Τελείωσε\n";
                message += $"Βρήκατε {player.WriteAnswers}/{TotalNumberQuestions} Σωστά\n";
                message += $"Έκανες {player.WrongAnswers} Λάθοι";
                MessageBox.Show(message);
                Window window = Window.GetWindow(this);
                window.Content = new QuizMenu();
            }
        }

        private void ShuffleQuestions<QuizData>()
        {
            Random random = new Random();
            Quizquestions = Quizquestions.OrderBy(x => random.Next()).ToList();
        }

        private void ShuffleAnswers<QuizData>()
        {
            Random random = new Random();
            Quizquestions[IndexQuestion].Answers = Quizquestions[IndexQuestion].Answers.OrderBy(x => random.Next()).ToList();
        }
    }
}