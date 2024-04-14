using System;
using System.Collections.Generic;

class Set
{
    private List<int> elements = new List<int>();
    private Random random = new Random();

    public void Add(int element)
    {
        if (!elements.Contains(element))
            elements.Add(element);
    }

    public void AddRandom()
    {
        int randomElement = random.Next(100); // Пример случайного числа от 0 до 99
        Add(randomElement);
    }

    public static Set operator +(Set set1, Set set2)
    {
        Set resultSet = new Set();
        resultSet.elements.AddRange(set1.elements);
        foreach (int element in set2.elements)
        {
            resultSet.Add(element);
        }
        return resultSet;
    }

    public int CompareTo(Set other)
    {
        if (other == null)
            return 1;
        return this.elements.Count.CompareTo(other.elements.Count);
    }

    public static implicit operator int(Set set)
    {
        return set.elements.Count;
    }

    public int this[int index]
    {
        get { return elements[index]; }
    }

    public int CountElements()
    {
        return elements.Count;
    }

    public override string ToString()
    {
        return $"{{ {string.Join(", ", elements)} }} ({elements.Count})";
    }

    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        public Owner(int id, string name, string organization)
        {
            Id = id;
            Name = name;
            Organization = organization;
        }
    }

    public class Date
    {
        public DateTime CreationDate { get; set; }

        public Date(DateTime creationDate)
        {
            CreationDate = creationDate;
        }
    }

    public static class StatisticOperation
    {
        public static int Sum(Set set)
        {
            int sum = 0;
            foreach (int element in set.elements)
            {
                sum += element;
            }
            return sum;
        }

        public static int Difference(Set set)
        {
            if (set.elements.Count == 0)
                return 0;
            int max = set.elements[0];
            int min = set.elements[0];
            foreach (int element in set.elements)
            {
                if (element > max)
                    max = element;
                if (element < min)
                    min = element;
            }
            return max - min;
        }

        public static int Count(Set set)
        {
            return set.elements.Count;
        }
    }
}
