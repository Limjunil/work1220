using System;

namespace Work221222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * LAB 1. [구현했습니다.]
             * 배열에서 최대값 찾기
             * 크기가 100인 배열을 1부터 100사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성.
             * 
             * - 보기 좋게 출력(가독성 높아야함)
             * - 이상한 입력 예외처리
             * 
             */


            // MaxArray1 이라는 배열 100 칸을 만듭니다.
            int[] MaxArray1 = new int[100];

            // for : BArraycount의 값을 0 선언하고, 100보다 작을 동안 반복 합니다.
            // 반복이 끝날때마다 Arraycount 값을 1 더합니다.
            for (int Arraycount = 0; Arraycount < 100; Arraycount++)
            {
                // 랜덤 변수를 선언합니다.
                Random Number1 = new Random();
                // Number1Val 변수에 0~100 까지의 난수 값을 선언합니다.
                int Number1Val = Number1.Next(0, 100 + 1);

                // MaxArray1[Arraycount] 배열 위치에 Number1Val 변수를 넣습니다.
                MaxArray1[Arraycount] += Number1Val;
            } // loop : 100번 도는 반복문

            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");
            // "MaxArray1 내의 배열 값들 입니다."를 출력하고 줄을 내립니다.
            Console.WriteLine("MaxArray1 내의 배열 값들 입니다.");
            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");


            // maxArrayGps: MaxArray1의 위치를 0부터 차례대로 하기 위해 변수 값 0을 선언
            int maxArrayGps = 0;

            // for : BmaxArraycount의 값을 1 선언하고, 그 값이 100 + 1 보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 maxArraycount 값을 1 더합니다.
            for (int maxArraycount = 1; maxArraycount < 100 + 1; maxArraycount++)
            {
                // MaxArray1[maxArrayGps] 값을 출력합니다.
                // \t| : 오른쪽 탭하고 |을 출력합니다.
                Console.Write("{0} \t|", MaxArray1[maxArrayGps]);

                // maxArrayGps 값에 1을 더합니다.
                maxArrayGps++;

                // if : maxArraycount가 10으로 나눈 나머지 값이 0이면 한 줄 내립니다.
                if (maxArraycount % 10 == 0)
                {
                    // 한 줄 내립니다.
                    Console.WriteLine();
                }
                // else : if 조건에 맞지 않으면 실행합니다.
                else { /* DO Nothing */ } // 아무 것도 안합니다.
            } // loop : 100번 도는 반복문


            // maxVal1 : 최대값을 저장할 변수에 값 0을 선언합니다.
            int maxVal1 = 0;

            // for : BmaxCount1의 값을 1 선언하고, 그 값이 MaxArray1 배열 길이보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 maxCount1 값을 1 더합니다.
            for (int maxCount1 = 0; maxCount1 < MaxArray1.Length; maxCount1++)
            {
                // if : maxVal1 값보다 MaxArray1[maxCount1] 값이 더 크다면 실행합니다.
                if (maxVal1 < MaxArray1[maxCount1])
                {
                    // MaxArray1[maxCount1] 값을 maxVal1에 선언합니다.
                    maxVal1 = MaxArray1[maxCount1];
                }
                // else : if 조건에 맞지 않으면 실행합니다.
                else { /* Do Nothing */ } // 아무 것도 안합니다.

            }

            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");
            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");
            // "현재 MaxArray1 내의 최대값은 {0} : maxVal1 입니다."를 출력합니다.
            Console.WriteLine("현재 MaxArray1 내의 최대값은 {0} 입니다.", maxVal1);
            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");
            // 가독성을 위해서 줄을 그었습니다.
            Console.WriteLine("================================================");





            /**
             * LAB 2. [구현했습니다.]
             * 사과를 제일 좋아하는 사람찾기
             * 사람들 5명 (사람1, 사람2, ..., 사람5)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
             * 데이터 입력이 마무리되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다.
             * 
             * - 이상한 입력 예외처리
             * - 제일 적게 먹은 사람도 찾도록 수정해보기(변형 1) [구현했습니다.]
             * 
             * - 먹은 사과의 개수 순으로 정렬. 
             *   정렬 알고리즘은 본인이 사용가능한 것으로 하되. 형태는 아래와 같음.
             *   알고리즘을 잘 모르겠다면 버블 정렬을 도전해볼 것.(변형 2) [구현했습니다.]
             *   
             * - 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것(변형 3) [구현하지 못했습니다.]
             *      - 정렬 도전 시 유저 입력 X
             *      - 데이터는 난수로 100~1000개 정도의 값
             *      - 중복 제거
             *      - 시간초는 전혀 상관 없음
             *      
             * - 본인의 능력껏 기본형, 변형 1, 변형 2, 여러운 거 난이도 순서로 도전해 볼 것.
             */

            // Applepeoples[5] : 사과 개수를 저장할 5칸 배열 선언
            int[] Applepeoples = new int[5];

            // countPeople : 사람 수를 저장할 변수에 0을 선언 
            int countPeople = 0;
            // Peoplecount : 현재 사람이 몇번째인지 보여줄 변수에 1을 선언
            int Peoplecount = 1;

            // while : countPeople 값이 5보다 작다면 반복
            while (countPeople < 5)
            {
                // 몇 번째 사람이 아침의 사과를 먹었는지 입력하는 안내를 출력
                // 문자열 보간법으로 Peoplecount 값을 이용해서 몇번째 사람인지 보여줍니다.
                Console.Write("{0} 번째 사람의 아침 사과 먹은 개수를 입력하시오 (0보다 커야합니다.): ", Peoplecount);
                // 유저가 입력한 값을 정수로 변환한다.
                // 그 값을 Applepeoples[countPeople] 위치에 넣는다.
                int.TryParse(Console.ReadLine(), out Applepeoples[countPeople]);

                // 한 줄 내린다.
                Console.WriteLine();

                // while : true 값을 이용해서 무한 반복한다.
                while (true)
                {
                    // check1 : 0 < Applepeoples[countPeople] 값이 참인지 거짓인지 선언합니다.
                    // 0 초과의 값이 아니면 이상한 입력으로 취급합니다.
                    bool check1 = 0 < Applepeoples[countPeople];

                    // if : 변수 check1의 값이 참이면 실행 
                    if (check1)
                    {
                        break; // 현재 반복문을 탈출합니다.
                    }
                    // else : if 조건에 맞지 않으면 실행합니다.
                    else 
                    {
                        // 몇 번째 사람이 이상한 입력을 했는지 안내를 출력
                        // 문자열 보간법으로 Peoplecount 값을 이용해서 몇번째 사람인지 보여줍니다.
                        Console.WriteLine("{0} 번째 값은 이상한 입력 입니다. 다시 아침에 먹은 사과 개수를 입력해주세요.", Peoplecount);
                        // 몇 번째 사람이 아침의 사과를 먹었는지 입력하는 안내를 출력
                        // 문자열 보간법으로 Peoplecount 값을 이용해서 몇번째 사람인지 보여줍니다.
                        Console.Write("{0} 번째 사람의 아침 사과 먹은 개수를 입력하시오 (0보다 커야합니다.): ", Peoplecount);
                        // 유저가 입력한 값을 정수로 변환한다.
                        // 그 값을 Applepeoples[countPeople] 위치에 넣는다.
                        int.TryParse(Console.ReadLine(), out Applepeoples[countPeople]);
                    }
                    // 한 줄 내립니다.
                    Console.WriteLine();
                } // loop : 무한 반복

                // Peoplecount 값에 1을 더합니다.
                Peoplecount++;
                // countPeople 값에 1을 더합니다.
                countPeople++;
            } // loop : 5번 반복하는 루프

            

            // maxVal2 : 최대값을 저장할 변수에 값 0을 선언합니다.
            int maxVal2 = 0;
            // minVal2 : 최솟값을 저장할 변수에 Applepeoples[0] 값을 선언합니다.
            int minVal2 = Applepeoples[0];


            // for : BmaxminCount의 값을 1 선언하고, 그 값이 Applepeoples 배열 길이보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 maxminCount1 값을 1 더합니다.
            for (int maxminCount = 0; maxminCount < Applepeoples.Length; maxminCount++)
            {
                // if : Applepeoples[maxminCount] 값보다 minVal2 값이 더 크다면 실행합니다.
                if (minVal2 > Applepeoples[maxminCount])
                {
                    // Applepeoples[maxminCount] 값을 minVal2에 선언합니다.
                    minVal2 = Applepeoples[maxminCount];
                }
                // else : if 조건에 맞지 않으면 실행합니다.
                else { /* Do Nothing */ }  // 아무 것도 안합니다.

                // if : maxVal2 값보다 Applepeoples[maxminCount] 값이 더 크다면 실행합니다.
                if (maxVal2 < Applepeoples[maxminCount])
                {
                    // Applepeoples[maxminCount] 값을 maxVal2에 선언합니다.
                    maxVal2 = Applepeoples[maxminCount];
                }
                // else : if 조건에 맞지 않으면 실행합니다.
                else { /* Do Nothing */ }  // 아무 것도 안합니다.

            } // loop : 5번 도는 반복

            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");

            // 현재 아침 사과의 입력 최댓값을 출력합니다.
            Console.WriteLine("현재 사과를 가장 많이 먹은 개수는 {0} 입니다.", maxVal2);

            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            // 현재 아침 사과의 입력 최솟값을 출력합니다.
            Console.WriteLine("현재 사과를 가장 적게 먹은 개수는 {0} 입니다.", minVal2);
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            
            
            // 비교를 위해 아침 사과의 배열을 입력한 순서대로 출력합니다.

            // 아침 사과의 먹은 개수 순이라는 말을 출력합니다.
            Console.WriteLine("아침 사과를 먹은 개수 순 입니다.");

            // foreach : int 형식의 Applepeocount 변수를 선언하고 Applepeoples 배열을 임시로 담습니다.
            foreach (int Applepeocount in Applepeoples)
            {
                // Applepeocount 변수 값을 차례로 출력합니다.
                // \t| : 오른쪽 탭하고 |을 출력합니다.
                Console.Write("{0} \t|", Applepeocount);
            } // loop : 5번 도는 반복
            // 한 줄 내립니다.
            Console.WriteLine();
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");
            // 가시성을 위해 줄을 긋고 한 줄 내립니다.
            Console.WriteLine("================================================");

            /**
             *  - 먹은 사과의 개수 순으로 정렬. 
             *    정렬 알고리즘은 본인이 사용가능한 것으로 하되. 형태는 아래와 같음.
             *    알고리즘을 잘 모르겠다면 버블 정렬을 도전해볼 것.(변형 2)
             */


            //// 배열 길이를 정수 값으로 넣을 변수 선언
            //int AppleLen = Applepeoples.Length;


            // AppleVal5 : 배열 내의 비교에서 큰 값을 저장할 변수에 값 0을 선언
            int AppleVal5 = 0;


            // ApplepeoplesSort : sort 알고리즘을 이용한 걸 확인하기 위해 새로운 5칸 배열 선언
            int[] ApplepeoplesSort = new int[5];
            // Applepeoples 배열을 ApplepeoplesSort에 선언합니다.
            ApplepeoplesSort = Applepeoples;

            // for : Bubble1의 값을 0 선언하고, 그 값이 Applepeoples 배열 길이보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 Bubble1 값을 1 더합니다.
            for (int Bubble1 = 0; Bubble1 < Applepeoples.Length; Bubble1++)
            {
                // for : Bubble2의 값을 Bubble1 + 1 선언하고, 그 값이 Applepeoples 배열 길이보다 작을 동안 반복합니다.
                // 반복이 끝날 때마다 Bubble2 값을 1 더합니다.
                for (int Bubble2 = Bubble1 + 1; Bubble2 < Applepeoples.Length; Bubble2++)
                {
                    // if : Applepeoples[Bubble1] 값이 Applepeoples[Bubble2] 보다 크다면 실행
                    if (Applepeoples[Bubble1] > Applepeoples[Bubble2])
                    {
                        // Applepeoples[Bubble1] 값을 AppleVal5 에 선언합니다.
                        AppleVal5 = Applepeoples[Bubble1];

                        //Applepeoples[Bubble2] 값을 Applepeoples[Bubble1] 에 선언합니다.
                        Applepeoples[Bubble1] = Applepeoples[Bubble2];

                        // AppleVal5 값을 Applepeoples[Bubble2] 에 선언합니다.
                        Applepeoples[Bubble2] = AppleVal5;
                    }
                } // loop : 4번 도는 반복
            } // loop : 5번 도는 반복

            // 오르차순으로 정렬했다는 말을 출력하고 한 줄 내립니다.
            Console.WriteLine("오름차순으로 정렬한 아침 사과를 먹은 개수 순 입니다.");

            // for : Bubblecount1의 값을 0 선언하고, 그 값이 Applepeoples 배열 길이보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 Bubblecount1 값을 1 더합니다.
            for (int Bubblecount1 = 0; Bubblecount1 < Applepeoples.Length; Bubblecount1++)
            {
                // Applepeoples[Bubblecount1] 값을 출력합니다.
                // \t| : 오른쪽 탭하고 |을 출력합니다.
                Console.Write("{0} \t|", Applepeoples[Bubblecount1]);
            } // loop : 5번 도는 반복
            // 한 줄 내립니다.
            Console.WriteLine();




            // 선택 정렬 (SORT) 알고리즘 :  데이터 하나를 기준으로 나머지 데이터와 비교하여
            // 가장 작거나 큰 데이터와 자리를 바꾸는 식으로 반복해서 비교하는 정렬 방법

            // AppleVal6 : 배열 내의 비교에서 큰 값을 저장할 변수에 값 0을 선언
            int AppleVal6 = 0;

            // for : sortcount1의 값을 0 선언하고, 그 값이 ApplepeoplesSort 배열 길이 -1 보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 sortcount1 값을 1 더합니다.
            for (int sortcount1 = 0; sortcount1 < ApplepeoplesSort.Length - 1; sortcount1++)
            {
                // for : sortcount2의 값을 0 선언하고, 그 값이 ApplepeoplesSort 배열 길이보다 작을 동안 반복합니다.
                // 반복이 끝날 때마다 sortcount2 값을 1 더합니다.
                for (int sortcount2 = sortcount1 + 1; sortcount2 < ApplepeoplesSort.Length; sortcount2++)
                {

                    // if : Applepeoples[sortcount1] 값이 Applepeoples[sortcount2] 보다 크다면 실행
                    if (ApplepeoplesSort[sortcount1] > ApplepeoplesSort[sortcount2])
                    {

                        // ApplepeoplesSort[sortcount1] 값을 AppleVal5에 선언한다.
                        AppleVal5 = ApplepeoplesSort[sortcount1];

                        // ApplepeoplesSort[sortcount2] 값을 ApplepeoplesSort[sortcount1]에 선언한다.
                        ApplepeoplesSort[sortcount1] = ApplepeoplesSort[sortcount2];

                        // AppleVal6 값을 ApplepeoplesSort[sortcount2]에 선언한다.
                        ApplepeoplesSort[sortcount2] = AppleVal5;
                    }
                    else { /* Do Nothing */ } // 아무 것도 하지 않는다.
                } // loop : 4번 도는 반복
            } // loop : 4번 도는 반복

            // sort로 정렬했다는 말을 출력하고 한 줄 내립니다.
            Console.WriteLine("sort으로 정렬한 아침 사과를 먹은 개수 순 입니다.");

            // for : sortcount2의 값을 0 선언하고, 그 값이 ApplepeoplesSort 배열 길이보다 작을 동안 반복합니다.
            // 반복이 끝날 때마다 sortcount2 값을 1 더합니다.
            for (int sortcount2 = 0; sortcount2 < ApplepeoplesSort.Length; sortcount2++)
            {
                // Applepeoples[Bubblecount1] 값을 출력합니다.
                // \t| : 오른쪽 탭하고 |을 출력합니다.
                Console.Write("{0} \t|", ApplepeoplesSort[sortcount2]);
            } // loop : 5번 도는 반복

            // 한 줄 내립니다.
            Console.WriteLine();


            /**
             * [구현하지 못했습니다.]
             * 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것(변형 3) 
             * - 정렬 도전 시 유저 입력 X
             * - 데이터는 난수로 100~1000개 정도의 값 (count는 100~1000개, value range는 임의로)
             * - 중복 제거
             * - 시간초는 전혀 상관 없음
             */

            // Applepeoples[5] : 사과 개수를 저장할 5칸 배열 선언
            //int[] Applepeoples2 = new int[150];

            //Random Number2 = new Random();

            //for (int Arraycount2 = 0; Arraycount2 < 150; Arraycount2++)
            //{

            //    int Number1Val2 = Number2.Next(0, 150 + 1);

            //    Applepeoples2[Arraycount2] += Number1Val2;
            //}

            //int[] Applepeoples3 = new int[150];
            //int count1 = 0;

            //for (int i = 0; i < Applepeoples2.Length; i++)
            //{
            //    bool flag = false;
            //    for (int j = 0; j < Applepeoples3.Length; j++)
            //    {
            //        if (Applepeoples2[i] == Applepeoples3[j])
            //        {
            //            flag = true;
            //        }

            //        if (flag == false)
            //        {
            //            Applepeoples3[count1] = Applepeoples2[i];
            //        }
            //    }
            //}



        }
    }
}