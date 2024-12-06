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
                // Ensure new file name doesn't already exist
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
    }
}