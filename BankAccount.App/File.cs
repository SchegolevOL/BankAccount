﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.App
{
    /// <summary>
    /// Static class for writing to a file
    /// Cтатический класс для записи в файл 
    /// </summary>
    internal static class File
    {
        /// <summary>
        /// Method of writing to the message file
        /// Метод записи в файл сообщения
        /// </summary>
        /// <param name="message">Recorded message (Записываемое сообщение)</param>
        /// <param name="filePath">File name(Имя файла)</param>
        public static void RecToFile(string message, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Unicode))
            {
                sw.WriteLine(message);
            }
        }
        /// <summary>
        /// Method for the delegate
        /// Recording messages on banking transactions
        /// Mетод для делегата
        /// Запись сообщений по банковским операциям
        /// </summary>
        /// <param name="message">Recorded message (Записываемое сообщение)</param>
        public static void RecToFileSuccess(string message) => RecToFile(message, "Success.txt");
        public static void RecToFileError(string message) => RecToFile(message, "Error.txt");

    }
}
