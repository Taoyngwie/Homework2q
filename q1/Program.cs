class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> Cll = new CircularLinkedList<char>();

        //สิ่งที่อยากฝากถึงผู้สอน
        //ผมรักพี่นะ พี่สอนดีมาก แต่ผมว่า เพื่อนเริ่มยับกันบ้างแล้ว หลุดบ้าง
        //ผมอาจไม่ได้เขียนโค้ดดีมาก เพราะผมเวลาน้อย ผมเรียนด้วยทำงานด้วย ผมเหนื่อยมาก 
        //ด้วยความที่ผมรักวิชานี้มากๆ ผมเลยหาเวลามานั่งทำโจทย์ ให้เสด อย่างน้อยส่งให้พี่ภูมิใจ 
        // อยากให้พี่เก็บมาตรฐานการสอนแบบน้เอาไว้ เพราะไม่รู้จะไปหาเรียนอีกได้จากที่ไหน คือผม ทุ่มทุนเรียนมาเยอะมาก 
        // ผมเรียนในห้อง เหมือนมาทบทวน พี่สอนโคตรดีเลย ถ้าคนที่มีพื้นมาก่อนคงชอบมากๆ ส่วนคนที่ทั่วไป อาจจะมีร้องไห้กันบ้าง
        // ผมเปนเด็กคนหนึ่งมีความคิดความฝัน อยากไปดาวอังคาร ผมไม่รู้ว่ามันจะยากสักขนาดไหน ข้างหน้าจะเป็นยังไง แต่ผมเกิดมาสักครั้งก็จะทำให้เต็มที่ครับ มันหนักมันเหนื่อยแน่นอน
        // ผมเต่าอิงวี่คับ ศิวกร ยวงแก้ว 

        char input;
        int countG = 0;
        int number = 0;


        while (true)
        {
            int countG2 = 0;
            int len = Cll.GetLength();
            input = Console.ReadLine()[0];
            if (input != 'j' && input != 'g' && input != 'r' && input != 'o') { break; }
            if (len == 0)
            {
                if (input == 'g' || input == 'j' || input == 'o')
                {
                    Cll.Add(input); number += 1;
                }
                else
                {
                    Console.WriteLine("Invalid pattern.");
                }
            }
            else if (input == 'r')
            {
                if (Cll.Get(Cll.GetLength() + number - 1) == 'r' || Cll.Get(Cll.GetLength() + number - 2) == 'r')
                {
                    Console.WriteLine("Invalid pattern.");
                }
                else
                {
                    Cll.Add(input); number += 1;
                }
            }
            else if (input == 'j' || input == 'g' || input == 'o')
            {
                if (Cll.Get(Cll.GetLength() + number - 1) == 'r') //ข้างหลังเป็น r
                {
                    if (Cll.Get(Cll.GetLength() + number - 2) == input)
                    {
                        Console.WriteLine("Invalid pattern.");
                    }
                    else if (input == 'j' || input == 'o')
                    {
                        Cll.Add(input);
                        number += 1;
                    }
                    else { Console.WriteLine("Invalid pattern."); }
                }
                else if (Cll.Get(Cll.GetLength() + number - 1) == 'g' && input == 'g')
                {

                    if (Cll.Get(Cll.GetLength()) == 'g')
                    {
                        countG2 = 0;
                        char x;
                        int j = 0;
                        while (j < Cll.GetLength())
                        {
                            if (Cll.Get(j) == 'g')
                            {
                                countG2++;
                            }
                            j++;
                        }
                        if (countG2 > 3)
                        {
                            Console.WriteLine("Invalid pattern.");
                        }
                    }
                    if (countG < 2 && Cll.Get(Cll.GetLength()) == 'g')
                    {
                        Cll.Add(input);
                        number += 1;
                        countG++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid pattern.");
                    }
                }
                else
                {
                    Cll.Add(input);
                    number += 1;
                }
            }
        }
        for (int i = 0; i < Cll.GetLength(); i++)
        {
            Console.Write("{0}", Cll.Get(i));
        }
    }
}
//dotnet run