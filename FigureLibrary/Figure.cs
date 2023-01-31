namespace FigureLibrary
{
    public abstract class Figure
    {
        public abstract double GetSquare();
        //На счет перегрузки основных методов не знаю - надо, не надо, но при масштабировании проекта могут где-то пригодиться
        public abstract override string ToString();
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
