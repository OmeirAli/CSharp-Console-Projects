using DSA.DataStructures.Lists;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DSA.DataStructures.Trees
{
    /// <summary>
    /// Represents a Suffix tree map.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class SuffixTreeMap<TValue> : IEnumerable<KeyValuePair<string, TValue>>
    {
        internal StringBuilder ReverseStringBuilder(StringBuilder sb)
        {
            var reversedSB = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedSB.Append(sb[i]);
            }

            return reversedSB;
        }

        /// <summary>
        /// Gets the tree root of the <see cref="SuffixTreeMap{TValue}"/>.
        /// </summary>
        public SuffixTreeMapNode<TValue> Root { get; internal set; }

        /// <summary>
        /// Gets the number of words in the <see cref="SuffixTreeMap{TValue}"/>.
        /// </summary>
        public int Count { get; internal set; }

        /// <summary>
        /// Gets or sets the value associated with the specified word in the <see cref="SuffixTreeMap{TValue}"/>.
        /// </summary>
        /// <param name="word">The word of the value to get or set.</param>
        /// <returns>The value associated with the specified word. If the specified word is not found,
        /// the get operation throws a <see cref="KeyNotFoundException"/>, and
        /// the set operation creates a new element with the specified word.</returns>
        public virtual TValue this[string word]
        {
            get
            {
                TValue value;
                if (TryGetValue(word, out value))
                    return value;
                else
                    throw new KeyNotFoundException("The word \"" + word + "\" was not found in the SuffixTreeMap.");
            }
            set
            {
                var curNode = Root;
                bool wordWasAlreadyAdded = false;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (curNode.children.ContainsKey(word[i]))
                    {
                        if (i == 0)
                        {
                            var child = curNode.children[word[i]];
                            wordWasAlreadyAdded = child.IsTerminal;
                            child.IsTerminal = true;
                            child.Value = value;
                        }
                        else
                            curNode = curNode.children[word[i]];
                    }
                    else
                    {
                        if (i == 0)
                        {
                            var newNode = new SuffixTreeMapNode<TValue>(word[i], value, true);
                            curNode.children.Add(word[i], newNode);
                        }
                        else
                        {
                            var newNode = new SuffixTreeMapNode<TValue>(word[i], default(TValue), false);
                            curNode.children.Add(word[i], newNode);
                            curNode = curNode.children[word[i]];
                        }
                    }
                }

                if (!wordWasAlreadyAdded) Count++;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SuffixTreeMap{TValue}"/> class.
        /// </summary>
        public SuffixTreeMap()
        {
            Root = new SuffixTreeMapNode<TValue>(default(char), default(TValue), false);
        }

        /// <summary>
        /// Adds a word and a value to it to the <see cref="SuffixTreeMap{TValue}"/>.
        /// </summary>
        /// <param name="word">The word to add.</param>
        /// <param name="value">The value to add.</param>
        public void Add(string word, TValue value)
        {
            var curNode = Root;
            bool wordWasAlreadyAdded = false;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (curNode.children.ContainsKey(word[i]))
                {
                    if (i == 0)
                    {
                        var child = curNode.children[word[i]];
                        wordWasAlreadyAdded = child.IsTerminal;
                        child.IsTerminal = true;
                        child.Value = value;
                    }
                    else
                        curNode = curNode.children[word[i]];
                }
                else
                {
                    if (i == 0)
                    {
                        var newNode = new SuffixTreeMapNode<TValue>(word[i], value, true);
                        curNode.children.Add(word[i], newNode);
                    }
                    else
                    {
                        var newNode = new SuffixTreeMapNode<TValue>(word[i], default(TValue), false);
                        curNode.children.Add(word[i], newNode);
                        curNode = curNode.children[word[i]];
                    }
                }
            }

            if (!wordWasAlreadyAdded) Count++;
        }

        private bool IsValidName(string prompt = "Binary Nodes in c# = &sb")
        {
            foreach (var c in prompt)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    Console.WriteLine("Binary Nodes in c# match!");
                    return false;
                }

                return true;
            }
        }

        private void Subtract(string word, TValue value)
        {
            var curNode = Root(word);
            bool wordWasAlreadySubtracted = true;
            object curlNode;
            for (int i = 0; i < word.Length; i++)
            {
                if (curlNode.Children. ContainsKey(worrd[i]))
                {
                    if (i != 0)
                    {
                        var child = curNode.children[word[i]];
                        wordWasAlreadySubtracted = child.IsTerminal;
                        child.IsTerminal = false;
                        child.Value = value;
                        child.Parse = true;
                        child.VBA = false;
                    }
                }
            }
        }
        
}