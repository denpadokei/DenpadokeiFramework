using System;
using System.Collections.Generic;
using System.Text;
using StatefulModel;
using System.Threading;
using Prism.Mvvm;
using System.Collections;

namespace DenpadokeiFramework.Collections
{
    public class ViewModelCollection<T> : BindableBase, ICollection<T>, IEnumerable<T>, IList<T>
    {
        /// <summary>要素コレクション を取得、設定</summary>
        private SynchronizationContextCollection<T> items_;
        /// <summary>要素コレクション を取得、設定</summary>
        public SynchronizationContextCollection<T> Items
        {
            get => this.items_;

            set => this.SetProperty(ref this.items_, value);
        }
        public T this[int index] { get => this.Items[index]; set => this.Items[index] = value; }

        public int Count => this.Items.Count;

        public bool IsReadOnly => this.Items.IsReadOnly;

        public void Add(T item)
        {
            this.Items.Add(item);
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public bool Contains(T item)
        {
            return this.Items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return this.Items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.Items.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return this.Items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.Items.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public ViewModelCollection(ISynchronizableNotifyChangedCollection<T> collection)
        {
            this.Items = collection.ToSyncedSynchronizationContextCollection(SynchronizationContext.Current);
        }
    }
}
