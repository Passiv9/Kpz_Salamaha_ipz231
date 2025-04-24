using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public Memento Save()
        {
            return new Memento(Content);
        }

        public void Restore(Memento memento)
        {
            Content = memento.GetState();
        }
    }

    public class Memento
    {
        private readonly string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }

    public class History
    {
        private Stack<Memento> _history = new Stack<Memento>();

        public void Push(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento Pop()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }

    public class TextEditor
    {
        private TextDocument _document;
        private History _history;

        public TextEditor()
        {
            _document = new TextDocument();
            _history = new History();
        }

        public void Type(string newText)
        {
            _history.Push(_document.Save());
            _document.Content += newText;
        }

        public void Undo()
        {
            var memento = _history.Pop();
            if (memento != null)
                _document.Restore(memento);
        }

        public void Print()
        {
            Console.WriteLine(_document.Content);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            editor.Type("Hello");
            editor.Print();

            editor.Type(" World");
            editor.Print();

            editor.Undo();
            editor.Print();

            editor.Undo();
            editor.Print();
        }
    }
}
