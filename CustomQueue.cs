namespace Conventions
{
    public class CustomQueue
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();


        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if(stack2.Count() == 0)
            {
                while(stack1.Count() > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if(stack2.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return stack2.Pop();
        }


        public int Peek()
        {

            if (stack2.Count() == 0)
            {
                while (stack1.Count() > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            else if(stack1.Count() != 0)
            {
                while (stack1.Count() > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return stack2.Peek();
        }

        public bool IsEmpty()
        {
            return stack1.Count() == 0 && stack2.Count() == 0;
        }
    }
}
