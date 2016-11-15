using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace AutoNS {

    /// <summary>
    /// Provides functionality for running and manipulating files
    /// </summary>
    public static class Auto {

        public const string _7_ZIP_PATH = "7-Zip\\7z.exe";

        /// <summary>
        /// Runs a program with redirected standard input.
        /// Standard output and error from the program is assigned to stdOut and stdErr
        /// </summary>
        /// <param name="fileName">path to the program to run</param>
        /// <param name="args">arguments to pass to the program</param>
        /// <param name="commands">commands to redirect to the program</param>
        /// <param name="stdOut">standard output from the program</param>
        /// <param name="stdErr">standard error from the program</param>
        public static void run(string fileName, string args, string[] commands,
            ref string stdOut, ref string stdErr)
        {

            // open a process
            using (Process process = new Process()) {

                // set process info
                process.StartInfo = new ProcessStartInfo {
                    FileName = fileName,
                    Arguments = args,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                };

                try {
                    process.Start(); // run the program

                    // open standard input stream
                    using (StreamWriter stdIn = process.StandardInput) {
                        foreach (string command in commands) {

                            // passing commands to standard input
                            stdIn.WriteLine(command);
                        }
                    }

                    // get output and error
                    stdOut = process.StandardOutput.ReadToEnd();
                    stdErr = process.StandardError.ReadToEnd();

                } catch (Exception ex) {

                    // something went wrong on our end
                    stdErr = "[Auto.run Exception] " + ex.Message;
                }
            }
        }

        /// <summary>
        /// Runs a program
        /// </summary>
        /// <param name="fileName">path to the program to run</param>
        /// <param name="args">arguments to pass to the program</param>
        /// <returns>false if an exception was thrown</returns>
        public static bool run(string fileName, string args = "") {
            try {

                // run the program
                Process.Start(fileName, args);

            } catch {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Uses 7-Zip to extract the contents of an archive
        /// </summary>
        /// <param name="fileName">path to the file to unzip</param>
        /// <param name="destination">fath to where the file contents are going</param>
        /// <returns>Output</returns>
        public static string unzip(string fileName, string destination) {
            string stdOut = "";
            string stdErr = "";

            run(
                _7_ZIP_PATH,

                // e (extract) fileName -y (yes to all) -o (output to) destination
                "e " + fileName + " -y -o" + destination,
                new string[0], // no commands
                ref stdOut,
                ref stdErr
            );

            return (stdOut.Trim() == "") ? stdErr : stdOut;
        }

        /// <summary>
        /// Moves the files in a directory to new directories in the output directory
        /// (or currentDir if not provided). Optionally, only the files that match a given regex matchstring
        /// will be moved.
        /// </summary>
        /// <param name="currentDir">directory to look in</param>
        /// <param name="outputDir">directory to create subdirectories within</param>
        /// <param name="regex">match string</param>
        /// <returns></returns>
        public static bool moveToSeparateDirs(DirectoryInfo currentDir, DirectoryInfo outputDir = null, string regex = "") {
            try {

                // create outputDir if it is given and it doesn't exist
                if (outputDir != null && !Directory.Exists(outputDir.FullName)) {
                    Directory.CreateDirectory(outputDir.FullName);
                }

                // default to currentDir if no outputDir is given
                string outPath = (outputDir != null) ? outputDir.FullName : currentDir.FullName;

                foreach (FileInfo file in currentDir.GetFiles()) {

                    // if we're given a matchstring
                    if (regex != "") {
                        if (Regex.IsMatch(file.Name, regex)) {

                            // move file to a directory of the matched string
                            safeMove(
                                file.FullName, 
                                outPath + "\\" + Regex.Match(file.Name, regex).ToString(),
                                file.Name
                            );
                        }

                    } else {

                        // move file to a directory of the same name
                        safeMove(file.FullName, outPath + "\\" + file.Name, file.Name);
                    }
                }

            } catch {
                return false;
            }

            return true;
        }

        private static bool safeMove(string filePath, string dirPath, string newFileName) {
            try {

                // if the directory doesn't exit, create it
                if (!Directory.Exists(dirPath)) {
                    Directory.CreateDirectory(dirPath);
                }
                
                // move the file there
                File.Move(filePath, dirPath + "\\" + newFileName);

            } catch {
                return false;
            }

            return true;
        }
    }
}
