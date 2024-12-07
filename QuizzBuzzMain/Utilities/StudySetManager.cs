using Microsoft.VisualBasic.ApplicationServices;
using QuizzBuzzMain.QuizQuestion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuizzBuzzMain.Utilities
{
    internal class StudySetManager
    {

        private string StudySetsDirectory { get; }

        public StudySetManager()
        {
            StudySetsDirectory = @"C:\Users\vangs\Documents\3112\QuizBuzzApplication\QuizzBuzzMain\StudySets\"; // Path to the study sets directory from Sang's Personal Computer

            //Arbitrary path to the study sets directory
            //StudySetsDirectory = Path.Combine(
            //    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            //    "QuizzBuzzMain",
            //    "StudySets"
            //);


            if (!Directory.Exists(StudySetsDirectory))
            {
                Directory.CreateDirectory(StudySetsDirectory);
            }
        }

        public List<string> GetAllStudySets()
        {
            string[] txtFiles = Directory.GetFiles(StudySetsDirectory, "*.txt");
            List<string> studySets = new List<string>();
            foreach (string file in txtFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                studySets.Add(fileName);
            }
            return studySets;
        }
        public async Task DeleteStudySetAsync(string filename)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, filename);
                File.Delete(fullPath);
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting study set: {ex.Message}", ex);
            }
        }

        public async Task CreateNewStudySetAsync(string studySetName)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, studySetName);
                using (FileStream fs = File.Create(fullPath))
                {
                    await Task.CompletedTask; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("And error has Occurred:" , ex);
            }


        }

        public List<string> LoadStudySet(string filename)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, filename);
                return File.ReadAllLines(fullPath).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading study set: {ex.Message}", ex);
            }
        }

        public async Task EditStudySetName(string oldFileName, string newFileName)
        {
            try
            {
                string oldFullPath = Path.Combine(StudySetsDirectory, oldFileName);
                string newFullPath = Path.Combine(StudySetsDirectory, newFileName);

                if (!File.Exists(oldFullPath))
                {
                    throw new FileNotFoundException("The file to be renamed does not exist.");
                }

                if (File.Exists(newFullPath))
                {
                    throw new IOException("A file with the new name already exists.");
                }

                
                File.Move(oldFullPath, newFullPath);
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error renaming study set: {ex.Message}", ex);
            }
        }

        public Dictionary<string, string> LoadStudySetContent(string filename)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, filename);
                string[] lines = File.ReadAllLines(fullPath);
                Dictionary<string, string> studySetContent = new Dictionary<string, string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    studySetContent.Add(parts[0], parts[1]);
                }
                return studySetContent;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading study set: {ex.Message}", ex);
            }
        }

        public void SaveContentToFile(string studySetName, DataGridView dataGridView)
        {
            try
            {
                string studySetPath = studySetName + ".txt";
                List<string> content = new List<string>();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    string? key = row.Cells[0].Value?.ToString();
                    string? value = row.Cells[1].Value?.ToString();

                    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                    {
                        content.Add($"{key},{value}");
                    }
                }
                
                File.WriteAllLines(Path.Combine(StudySetsDirectory, studySetPath), content);
                MessageBox.Show("Content saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<IQuestionType> GenerateMultipleChoiceQuestions(string filename)
        {
            var questions = new List<IQuestionType>();
            var studySet = LoadStudySetContent(filename);

            foreach (var entry in studySet)
            {
                var options = studySet.Values.OrderBy(x => Guid.NewGuid()).Take(3).ToList(); 
                options.Add(entry.Value); 
                options = options.OrderBy(x => Guid.NewGuid()).ToList(); 

                questions.Add(new MultipleChoiceQuestion
                {
                    QuestionText = $"What is '{entry.Key}'?",
                    Options = options,
                    CorrectAnswer = entry.Value
                });
            }

            return questions.Take(10).ToList(); 
        }

        public List<IQuestionType> GenerateTrueFalseQuestions(string filename)
        {
            var questions = new List<IQuestionType>();
            var studySet = LoadStudySetContent(filename);

            foreach (var entry in studySet)
            {
                bool isCorrect = new Random().Next(0, 2) == 1;
                string displayedAnswer = isCorrect ? entry.Value : studySet.Values.OrderBy(x => Guid.NewGuid()).First();

                questions.Add(new TrueFalseQuestions
                {
                    QuestionText = $"Is the definition of '{entry.Key}' '{displayedAnswer}'?",
                    CorrectAnswer = isCorrect
                });
            }

            return questions.Take(10).ToList();
        }

    }
}