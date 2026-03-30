namespace DoublyLinkedList.Tests
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void TestInsertHeadAndTail_ShouldWork()
        {
            var list = new DoublyLinkedList<int>();
            list.InsertHead(20);
            list.InsertHead(10);
            list.InsertTail(30);

            Assert.Equal("[10, 20, 30]",list.ToString());
            Assert.Equal(3, list.Size);
        }

        [Fact]
        public void TestSearch_ShouldReturnCorrectIndex()
        {
            var list = new DoublyLinkedList<int>();
            list.InsertTail(10);
            list.InsertTail(20);
            list.InsertTail(30);
            Assert.Equal(1, list.Search(20));
            Assert.Equal(-1, list.Search(40));
        }

        [Fact]
        public void TestRemoveByValue_ShouldRemoveElement()
        {
            var list = new DoublyLinkedList<int>();
            list.InsertTail(10);
            list.InsertTail(20);
            list.InsertTail(30);
            bool removed = list.RemoveByValue(20);
            Assert.True(removed);
            Assert.Equal("[10, 30]", list.ToString());
            Assert.Equal(2, list.Size);
        }

        [Fact]
        public void TestRemoveDuplicates_ShouldRemoveAllDuplicates()
        {
            var list = new DoublyLinkedList<int>();
            list.InsertTail(10);
            list.InsertTail(20);
            list.InsertTail(10);
            list.InsertTail(30);
            list.InsertTail(20);
            list.RemoveDuplicates();
            Assert.Equal("[10, 20, 30]", list.ToString());
            Assert.Equal(3, list.Size);

        }

    }
}
