using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Calendar
{
    internal class Calendar
    {
        private Node head;
        private int size;

        public Calendar()
        {
            head = null;
            size = 0;
        }

        private class Node
        {
            public Date Date { get; set; }
            public Node Next { get; set; }

            public Node(Date date)
            {
                Date = date;
                Next = null;
            }
        }

        public void Add(Date date)
        {
            Node node = new Node(date);

            if (head == null)
            {
                head = node;
                node.Next = head;
            }
            else
            {
                Node current = head;

                while (current.Next != head)
                {
                    current = current.Next;
                }

                current.Next = node;
                node.Next = head;
            }

            size++;
        }

        public void Remove(Date date)
        {
            if (head == null)
            {
                return;
            }

            Node current = head;
            Node previous = null;

            do
            {
                if (current.Date.Equals(date))
                {
                    if (previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    size--;
                    return;
                }

                previous = current;
                current = current.Next;
            } while (current != head);
        }

        public List<Date> GetDatesForMonth(int month, int year)
        {
            List<Date> dates = new List<Date>();

            if (head == null)
            {
                return dates;
            }

            Node current = head;

            do
            {
                if (current.Date.Month == month && current.Date.Year == year)
                {
                    dates.Add(current.Date);
                }

                current = current.Next;
            } while (current != head);

            return dates;
        }
    }
}
