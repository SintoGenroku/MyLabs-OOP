using System;
using System.IO;

namespace lab13
{
    static class BASDiskInfo
    {
        public static void DiskInfo(DriveInfo[] drives)
        {
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"\nНазвание: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                Console.WriteLine($"Имя файловой системы: {drive.DriveFormat}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize / 1073741824} ГБ");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / 1073741824} ГБ");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
        }
    }

    static class BASFileInfo
    {
        public static void FileInfo(FileInfo file) 
        {
            if (file.Exists)
            {
                Console.WriteLine($"\nФайл: '{file.Name}',расшиерние: {file.Extension}, размер: {file.Length}");
                Console.WriteLine($"Полный путь: {file.DirectoryName}");
                Console.WriteLine($"Дата создания:{file.CreationTime}");
                Console.WriteLine($"Дата последнего изменения { file.LastWriteTime }");
            }
        }
    }

    static class BASDirInfo 
    {
        public static void DirInfo(DirectoryInfo dir)
        {
            if (dir.Exists)
            {
                Console.WriteLine($"\nПапка: {dir.Name}");
                Console.WriteLine($"Кол-во файлов: {dir.GetFiles().Length}");
                Console.WriteLine($"Дата создания: {dir.CreationTime}");
                Console.WriteLine($"Кол-во поддиректорий: {dir.GetDirectories().Length}");
                Console.WriteLine($"Список родительских директорий: {dir.Parent}");
            }
        }
    }
}
