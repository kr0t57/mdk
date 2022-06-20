using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal sealed class Program
    {
        private static readonly List<Vector> directions = new()
        {
            new Vector(-1, 0),
            new Vector(1, 0),
            new Vector(0, -1),
            new Vector(0, 1)
        };

        private static void Main()
        {
            Vector arraySize = Vector.InputVector();

            int[,] array = new int[arraySize.Y, arraySize.X];

            for (int i = 0; i < arraySize.Y; i++)
            {
                for (int j = 0; j < arraySize.X; j++)
                {
                    array[i, j] = -1;
                }
            }

            Vector startPosition = Vector.InputVector();

            Vector endPosition;

            do
            {
                endPosition = Vector.GetRandomVector(arraySize.X, arraySize.Y);
            } while (startPosition == endPosition);

            array[startPosition.Y, startPosition.X] = 0;
            array[endPosition.Y, endPosition.X] = 99;

            CreateObstacles(8, startPosition, endPosition, array);
            FindPaths(endPosition, array);

            Vector[] path = RestorePath(startPosition, endPosition, array);

            DrawMap(array, startPosition, endPosition, path);
        }

        /// <summary>
        /// Нарисовать карту
        /// </summary>
        /// <param name="array">Массив значений</param>
        /// <param name="startPosition">Начальная позиция</param>
        /// <param name="endPosition">Конечная позиция</param>
        /// <param name="discoveredPath">Найденный путь</param>
        private static void DrawMap(int[,] array, Vector startPosition, Vector endPosition, Vector[] discoveredPath)
        {
            ConsoleColor color;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    switch (array[i, j])
                    {
                        case -2:
                            color = ConsoleColor.DarkRed;
                            break;
                        case -1:
                            color = ConsoleColor.DarkGreen;
                            break;
                        default:
                            Vector position = new Vector(j, i);
                            if (position == startPosition || position == endPosition)
                            {
                                color = ConsoleColor.DarkYellow;
                            }
                            else if (discoveredPath != null && discoveredPath.Contains(position))
                            {
                                color = ConsoleColor.Yellow;
                            }
                            else
                            {
                                color = ConsoleColor.White;
                            }
                            break;
                    }
                    Console.ForegroundColor = color;
                    Console.Write("{0,5}", $"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Создание препятствий
        /// </summary>
        /// <param name="obstaclesCount">Количество</param>
        /// <param name="startPosition">Начальная позиция</param>
        /// <param name="endPosition">Конечная позиция</param>
        /// <param name="array">Массив значений</param>
        private static void CreateObstacles(int obstaclesCount, Vector startPosition, Vector endPosition, int[,] array)
        {
            for (int i = 0; i < obstaclesCount; i++)
            {
                Vector obstacle = Vector.GetRandomVector(array.GetLength(1), array.GetLength(0));

                if (obstacle != startPosition && obstacle != endPosition)
                {
                    array[obstacle.Y, obstacle.X] = -2;
                }
            }
        }

        /// <summary>
        /// Поиск всех возможных путей
        /// </summary>
        /// <param name="endPosition">Конечная позиция</param>
        /// <param name="array">Массив значений</param>
        private static void FindPaths(Vector endPosition, int[,] array)
        {
            int d = 0, x, y;

            int arrayX = array.GetLength(1);
            int arrayY = array.GetLength(0);

            do
            {
                for (int i = 0; i < arrayY; i++)
                {
                    for (int j = 0; j < arrayX; j++)
                    {
                        if (array[i, j] == d)
                        {
                            foreach (Vector direction in directions)
                            {
                                x = j + direction.X;
                                y = i + direction.Y;

                                if (x >= 0 && x < arrayX && y >= 0 && y < arrayY)
                                {
                                    if (array[y, x] == 99)
                                    {
                                        array[y, x] = d + 1;
                                        return;
                                    }
                                    if (array[y, x] == -1)
                                    {
                                        array[y, x] = d + 1;
                                    }
                                }
                            }
                        }
                    }
                }
                d += 1;
            } while (array[endPosition.Y, endPosition.X] == 99);
        }

        /// <summary>
        /// Восстановление пути
        /// </summary>
        /// <param name="startPosition">Начальная позиция</param>
        /// <param name="endPosition">Конечная позиция</param>
        /// <param name="array">Массив значений</param>
        /// <returns>Возвращает найденный путь</returns>
        private static Vector[] RestorePath(Vector startPosition, Vector endPosition, int[,] array)
        {
            List<Vector> path = new();

            bool result = true;

            Vector lastPosition = endPosition;

            while (lastPosition != startPosition)
            {
                foreach (Vector direction in directions)
                {
                    Vector newPosition = direction + lastPosition;

                    if (newPosition.X >= 0 && newPosition.X < array.GetLength(1) && newPosition.Y >= 0 && newPosition.Y < array.GetLength(0))
                    {
                        if (array[newPosition.Y, newPosition.X] == array[lastPosition.Y, lastPosition.X] - 1)
                        {
                            path.Add(newPosition);
                            lastPosition = newPosition;
                            result = true;
                            break;
                        }
                    }

                    result = false;
                }

                if (result == false)
                {
                    return null;
                }
            }

            return path.ToArray();
        }
    }

    internal struct Vector
    {
        private readonly int _x;
        private readonly int _y;

        internal Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        internal int X => _x;
        internal int Y => _y;

        /// <summary>
        /// Ввести вектор с клавиатуры
        /// </summary>
        /// <returns>Возвращает введённый вектор</returns>
        internal static Vector InputVector()
        {
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            return new Vector(x, y);
        }

        /// <summary>
        /// Генерирует случайный вектор в гранницах от 0 до maxX, от 0 до maxY
        /// </summary>
        /// <param name="maxX">Верхняя граница по x</param>
        /// <param name="maxY">Верхняя граница по y</param>
        /// <returns>Возвращает случайный вектор</returns>
        internal static Vector GetRandomVector(int maxX, int maxY)
        {
            Random random = new();
            return new Vector(random.Next(maxX), random.Next(maxY));
        }

        /// <summary>
        /// Генерирует случайный вектор в гранницах от minX до maxX, от minY до maxY
        /// </summary>
        /// <param name="minX">Нижняя граница по x</param>
        /// <param name="minY">Нижняя граница по y</param>
        /// <param name="maxX">Верхняя граница по x</param>
        /// <param name="maxY">Верхняя граница по y</param>
        /// <returns>Возвращает случайный вектор</returns>
        internal static Vector GetRandomVector(int minX, int minY, int maxX, int maxY)
        {
            Random random = new();
            return new Vector(random.Next(minX, maxX), random.Next(minY, maxY));
        }

        public static bool operator ==(Vector vector, Vector vector2)
        {
            return vector.X == vector2.X && vector.Y == vector2.Y;
        }

        public static bool operator !=(Vector vector, Vector vector2)
        {
            return vector.X != vector2.X || vector.Y != vector2.Y;
        }

        public static Vector operator +(Vector vector, Vector vector2)
        {
            return new Vector(vector.X + vector2.X, vector.Y + vector2.Y);
        }

        public static Vector operator -(Vector vector, Vector vector2)
        {
            return new Vector(vector.X - vector2.X, vector.Y - vector2.Y);
        }
    }
}