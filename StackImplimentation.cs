namespace Conventions
{
    public class StackImplimentation
    {
        private Stack<int> stack = new Stack<int>();
        public void Push(int value)
        {
            stack.Push(value);
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Peek()
        {
            return stack.Peek();
        }
    }
}
