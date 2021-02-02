using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace uebung6._2048 {
    public class Game {
        public readonly int Dim;
        public readonly int[,] PlayGround;
        private bool playing = true;
        public Game(int dim) {
            if (dim < 4) throw new Exception("Play Ground toooooo small!");
            Dim = dim;
            PlayGround = new int[Dim, Dim];
            initPlayGround();
            StartOperation();
        }

        #region private methods
        private void StartOperation() {
            while (playing) {
                Operate(Console.ReadKey().Key);
            }
        }

        private void initPlayGround() {
            var random = new Random();
            for (int i = 0; i < Dim; i++) {
                PlayGround[i, random.Next(0, Dim)] = 2;
            }
            DisPlay();
        }

        private void Operate(ConsoleKey direction) {
            switch (direction) {
                case ConsoleKey.UpArrow:
                    OnUpArrow();
                    break;
                case ConsoleKey.DownArrow:
                    OnDownArrow();
                    break;
                case ConsoleKey.LeftArrow:
                    OnLeftArrow();
                    break;
                case ConsoleKey.RightArrow:
                    OnRightArrow();
                    break;
            }
            DisPlay();
        }

        private void OnUpArrow() { }

        private void OnDownArrow() { }

        private void OnLeftArrow() { }

        private void OnRightArrow() { }

        private void DisPlay() {
            Console.Clear();
            Console.WriteLine(ToString());
        }
        #endregion

        public override string ToString() {
            var str = new StringBuilder();
            for(int x = 0; x < Dim; x++) {
                for(int y = 0; y < Dim; y++) {
                    str.Append($"{PlayGround[x, y]}\t");
                }
                str.Append("\n");
            }
            return str.ToString();
        }
    }
}
