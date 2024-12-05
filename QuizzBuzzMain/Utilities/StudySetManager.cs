using Microsoft.VisualBasic.ApplicationServices;
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
            StudySetsDirectory = @"C:\Users\vangs\Documents\ITCS3112\QuizBuzz\QuizBuzzApplication\QuizzBuzzMain\StudySets\"; // Path to the study sets directory from Sang's Personal Computer

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
        public void DeleteStudySet(string filename)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, filename);
                File.Delete(fullPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting study set: {ex.Message}", ex);
            }
        }

        public void CreateNewStudySet(string studySetName)
        {
            // File name to save the study set folder
            // File name with spaces are replaced with underscores
            string fileName = studySetName.Replace(" ", "_") + ".txt";
            string fullPath = Path.Combine(StudySetsDirectory, fileName);

        }

        // Load a specific study set
        public List<string> LoadStudySet(string filename)
        {
            try
            {
                string fullPath = Path.Combine(StudySetsDirectory, filename);
                return File.ReadAllLines(fullPath).ToList();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception($"Error loading study set: {ex.Message}", ex);
            }
        }
    }
}