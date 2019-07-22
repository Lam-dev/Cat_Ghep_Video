using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditor
{
    class FFmpeg
    {
        public static bool ExecuteCommand(string exeDir, string args)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo();

                procStartInfo.FileName = exeDir;
                procStartInfo.Arguments = args;
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                using (Process process = new Process())
                {
                    process.StartInfo = procStartInfo;
                    process.Start();
                    process.WaitForExit();
                    string result = process.StandardOutput.ReadToEnd();
                    Console.WriteLine(result);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("*** Error occured executing the following commands.");
                Console.WriteLine(exeDir);
                Console.WriteLine(args);
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public static bool cutVideo(string filePath, string outputPath, string startTime, string duration)
        {
            var parameter = "-ss " + startTime + " -i " + filePath + " -to " + duration + " -c copy " + outputPath;
            return ExecuteCommand(@"..\..\..\lib\ffmpeg\v4\ffmpeg.exe", parameter);
            
        }

        public static bool concatVideo(int numberVideoAdd, string outputPath, string width, string heigh, bool isTheSame)
        {
            var parameter = "";
            if (isTheSame)
            {
                parameter = "-f  concat -safe 1 -i listVideo.txt -c copy " + outputPath;
                return ExecuteCommand(@"..\..\..\lib\ffmpeg\v4\ffmpeg.exe", parameter);
            }
            parameter = "-y -loglevel warning ";
            for (int i = 0; i < numberVideoAdd; i++)
            {
                parameter += "-i " + i.ToString() + ".mp4 ";
            }
            parameter += "-filter_complex \"";
            for (int i = 0; i < numberVideoAdd; i++)
            {
                parameter += $@"[{i}:v] scale = w = min(iw * {heigh} / ih\, {width}):h = min({heigh}\, ih * {width} / iw), pad = w = {width}:h = {heigh}:x = ({width} - iw) / 2:y = ({heigh} - ih) / 2 [video{i}]; ";
            }
          
            for (int i = 0; i < numberVideoAdd; i++)
            {
                parameter += $"[video{i}]";
            }
            parameter += $" concat=n={numberVideoAdd}:v=1 [v]\" -map \"[v]\" -an -c:v libx264 -crf 23 -preset veryfast -f mp4 {outputPath}";
            //var parameter = "-f  concat -safe 1 -i listVideo.txt -c copy " + outputPath;
            return ExecuteCommand(@"..\..\..\lib\ffmpeg\v4\ffmpeg.exe", parameter);
        }
    }
}
