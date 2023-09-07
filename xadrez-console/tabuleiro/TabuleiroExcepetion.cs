using System;
namespace tabuleiro
{
    internal class TabuleiroExcepetion : Exception 
    {
        public TabuleiroExcepetion(string msg) : base(msg)
        {
        }
    }
}
