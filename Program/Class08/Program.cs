using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_08 {
    public class GameObject {
        private string name = "";
        public string Name {
            set { name = value; }
            get { return name; }
        }
    }
    class Program {
        static void Main(string[] args) {
            #region 콜렉션
            #region ArrayList
            /*
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("string");
            arrayList.Add(57.7f);
            arrayList.Add('A');

            foreach (object item in arrayList) {
                Console.WriteLine(item);
            }
            Console.WriteLine("arrayList Count: " + arrayList.Count);
            Console.WriteLine("");
            arrayList.Remove(10);
            foreach (object item in arrayList) {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region List
            /*
            List<string> list = new List<string>();
            list.Capacity = 10;

            list.Add("메이플스토리");
            list.Add("서든어택");
            list.Add("바람의나라");
            list.Add("피파온라인");
            list.Add("마구마구");

            for (int i = 0; i < list.Count; i++) {
                int ran = new Random().Next(0, list.Count);
                Console.WriteLine(list[ran]);
                list.RemoveAt(ran);
            }
            
            //list.Remove(45);
            //list.RemoveAt(4);

            //list.Reverse(); -> 리스트의 원소의 순서를 반전
            //list.Sort(); -> 리스트의 원소를 정렬

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("");
            */
            #endregion

            #region LinkedList
            /*
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddLast(100);

            foreach (var item in linkedlist) {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region Random 클래스
            //Random random = new Random();
            //int rand = random.Next(0, 10);

            //Console.WriteLine("rand: " + rand);
            #endregion

            #region Stack
            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            //stack.Pop(); //가장 위에 데이터 삭제
            Console.WriteLine("Stack_Peek: " + stack.Peek());// 가장 위에 데이터 반환
            foreach (var item in stack) {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region Queue
            //List<string> names = new List<string>() { "Cube", "Sphere", "Capsule", "Cylinder" };
            //GameObject gameObject = null;
            //Queue<GameObject> queue = new Queue<GameObject>();
            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());
            //queue.Enqueue(new GameObject());

            //int cnt = queue.Count;
            //for (int i = 0; i < cnt; i++) {
            //    gameObject = queue.Dequeue();
            //    gameObject.Name = names[i];
            //    Console.WriteLine(gameObject.Name);
            //}
            #endregion

            #region HashTable
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("Sword", 1000);
            //hashtable.Add('A', 57.5f);

            //foreach (DictionaryEntry pair in hashtable) {
            //    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            //}
            #endregion

            #region dictionary
            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("MapleStroy", 2003);
            //dictionary.Add("League of Legends", 2011);
            //dictionary.Add("MiniFighter", 2006);

            //if (dictionary.ContainsKey("MapleStroy")) {
            //    Console.WriteLine("Key가 존재합니다.");
            //}

            //foreach (var item in dictionary) {
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion
        }
    }
}
