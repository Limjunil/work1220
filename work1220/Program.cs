using System;

namespace work1220
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**
             * LAB 문제 1 
             * 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * (대, 소문자 모두 카운트)
             * ex) a
             * b
             * c
             * d
             * e
             * #
             * 모음: 2
             * 자음: 3
             */

            int vowelscount = 0;        // 모음 개수 변수 선언 
            int consonantscount = 0;    // 자음 개수 변수 선언
            char alphaBatcount = '$';   // 입력되는 알파벳을 끝낼 특수문자가 들어갈 변수 선언

            while (alphaBatcount != '#')  // while 반복 처리(!= : 같지 않으면 true 처리)
            {
                Console.Write("영문자를 입력하시오. : ");      // 무슨 값을 입력해야 하는지 알려주는 출력문
                char alphaBat = Convert.ToChar(Console.ReadLine()); // 입력받은 알파벳을 char 선언 처리

                switch (alphaBat)         // 입력한 알파벳에 따라 처리
                {                         // case에 모음 알파벳들로 정리했습니다.
                    case 'a':             // 'a' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'A':             // 'A' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'e':             // 'e' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'E':             // 'E' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'i':             // 'i' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'I':             // 'I' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'o':             // 'o' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'O':             // 'O' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'u':             // 'u' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case 'U':             // 'U' 입력 값을 받을 때
                        vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
                        break;            // switch 문을 종료
                    case '#':                // #을 입력 받을때
                        alphaBatcount = '#'; // alphaBatcount 변수를 #으로 바꿈
                        break;               // switch 문 탈출
                    default:                  // 나머지 입력 값들
                        consonantscount++;    // consonantscount 변수 값에 1을 더합니다.
                        break;                   // switch 문 탈출

                } // switch : 알파벳 찾는 switch

            } // while : #이 입력될 때까지 반복

            Console.WriteLine("모음의 개수 : {0}", vowelscount);       // 모음의 개수를 모아둔 변수 vowelscount를 출력
            Console.WriteLine("자음의 개수 : {0}", consonantscount);   // 자음의 개수를 모아둔 변수 consonantscount를 출력


            /**
             * LAB 문제 2
             * 숫자 맞추기 게임
             * 숫자 알아맞히기 게임이다. 프로그램은 1~100 사이의 정수를 저장하고 있음.
             * 사용자는 질문을 통해서 숫자를 알아 맞힌다. 사용자가 답을 제시하면 프로그램은 제시된
             * 정수가 더 낮은 값인지, 높은 값인지 알려준다.
             * 사용자가 알아맞힐 때까지 루프한다.(기본형)
             */

            Random Dice1 = new Random();           // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int Dice1val = Dice1.Next(1, 100 + 1); // Dice1val는 1~100 사이의 난수형 정수 값이며, 사용자가 맞춰야 하는 숫자입니다.

            while (Dice1val > 0)    // Dice1val 값이 0보다 크면 반복합니다.
            {
                Console.Write("1~100 사이의 정답을 맞추시오 : "); 
                int sltNumber = Convert.ToInt32(Console.ReadLine()); // 사용자의 입력을 받아 sltNumber에 int로 받습니다.

                if (Dice1val > sltNumber) // Dice1val 값이 sltNumber 보다 크다면 "더 큰 값입니다." 라고 출력합니다.
                {
                    Console.WriteLine("더 큰 값입니다.");

                } 
                else if (Dice1val < sltNumber) // Dice1val 값이 sltNumber 보다 작다면 "더 작은 값입니다." 라고 출력합니다.
                {
                    Console.WriteLine("더 작은 값입니다.");
                }
                else        // Dice1val 값이 sltNumber과 같으면 "정답입니다."를 출력하고 break 문을 활용해서 탈출합니다.
                {
                    Console.WriteLine("정답입니다.");
                    break;
                } 

            } // loop : 정답을 맞출 때까지 반복합니다.


            /**
             * LAB 문제 2 - 어려움 1 
             * 프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에 사용자가 결정한
             * 번호를 컴퓨터가 추측하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를
             * 컴퓨터에 알려야한다. 컴퓨터가 맞힐때까지 반복.(어려움 1)
             */

            Console.Write("1~100 사이의 정답이 될 숫자를 골라주세요. : "); // 사용자의 입력을 받아 PassNumber에 int로 받습니다.
            int PassNumber = Convert.ToInt32(Console.ReadLine());

            Random ComputerNumber = new Random(); // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int ComputerNumberval = ComputerNumber.Next(1, 100 + 1); // ComputerNumberval는 1~100 사이의 난수형 정수 값입니다.

            while (PassNumber != ComputerNumberval) // PassNumber와 ComputerNumberval이 같지 않으면 반복합니다.
            {
                if (PassNumber > ComputerNumberval) // PassNumber가 ComputerNumberval 보다 크다면 "입력된 값이 낮습니다."를 출력합니다.
                {
                    Console.WriteLine("입력된 값이 낮습니다.");
                    ComputerNumberval++; // ComputerNumberval 변수 값에 1을 더합니다.

                }
                else // PassNumber가 ComputerNumberval 보다 작다면 "입력된 값이 높습니다."를 출력합니다.
                {
                    Console.WriteLine("입력된 값이 높습니다.");
                    ComputerNumberval--; // ComputerNumberval 변수 값에 1을 뺍니다.
                }
            } // loop : 컴퓨터가 정답을 맞출 때까지 반복
            Console.WriteLine("정답입니다."); // "정답입니다." 를 출력합니다.


            /**
             * LAB 문제 2 - 어려움 2
             * 사용자가 결정한 값의 범위는 (1~100) 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수
             * 있도록 어려움 1을 수정하시오. (어려움 2)
             */
            int Valuecount = 0; // Valuecount : 횟수에 대한 변수 선언

            Console.Write("1~100 사이의 정답이 될 숫자를 골라주세요. 기회는 7번 주어집니다. : "); // 사용자의 입력을 받아 PassNumber2에 int로 받습니다.
            int PassNumber2 = Convert.ToInt32(Console.ReadLine());


            Random ComputerNumber2 = new Random();  // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int ComputerNumberval2 = ComputerNumber2.Next(1, 100 + 1); // ComputerNumberval2는 1~100 사이의 난수형 정수 값입니다.

            while (Valuecount < 7 + 1) // Valuecount가 7 초과되기 전까지 반복 합니다.
            {
                // PassNumber2가 ComputerNumberval2 보다 크다면 "입력된 값이 낮습니다."를 출력합니다.
                if (PassNumber2 > ComputerNumberval2)
                {
                    Console.WriteLine("입력된 값이 낮습니다.");
                    ComputerNumberval2++; // ComputerNumberval2 변수 값을 1 더합니다.
                    Valuecount++;         // Valuecount 변수 값을 1 더합니다.

                }
                // PassNumber2가 ComputerNumberval2 보다 작다면 "입력된 값이 높습니다."를 출력합니다.
                else if (PassNumber2 < ComputerNumberval2)
                {
                    Console.WriteLine("입력된 값이 높습니다.");
                    ComputerNumberval2--; // ComputerNumberval2 변수 값을 1 뺍니다.
                    Valuecount++;         // Valuecount 변수 값을 1 뺍니다.
                }
                //  PassNumber2와 ComputerNumberval2가 같다면 "정답입니다."를 출력합니다.
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;  // break 문을 활용해서 탈출합니다.
                }
            } // loop : 횟수 값이 7을 넘어가면 종료
            Console.WriteLine("끝났습니다."); // "끝났습니다."를 출력합니다.


            /**
             * LAB 문제 3
             * 산수 문제 자동 출제
             * 산수 문제를 자동으로 출제하는 프로그램을 작성해보자.
             * 덧셈 문제들을 자동으로 생성해야 한다.
             * 
             * 피연산자는 0~99 사이의 숫자 (난수) 한 번이라도 맞으면 종료 틀리면 리트라이(기본형)
             * 
             */
            Random numberplus = new Random();   // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int number1val1plus = numberplus.Next(0, 99 + 1); // number1val1plus는 0~99 사이의 난수형 정수 값입니다.
            int number1val2plus = numberplus.Next(0, 99 + 1); // number1val2plus는 0~99 사이의 난수형 정수 값입니다.

            int numberplusadd = number1val1plus + number1val2plus; // numberplusadd 변수 값에 (number1val1plus + number1val2plus)의 값을 선언합니다.

            int correct1 = 0; // correct1 : 정답 값을 넣을 변수 선언

            while (numberplusadd != correct1) // numberplusadd와 correct1가 같아질 때까지 반복합니다.
            {
                // number1val1plus, number1val2plus의 값과 "{0} + {1} 의 정답을 맞추시오 : "을 출력합니다. 
                Console.Write("{0} + {1} 의 정답을 맞추시오 : ", number1val1plus, number1val2plus);
                correct1 = Convert.ToInt32(Console.ReadLine()); // 사용자의 입력을 받아 correct1에 int로 받습니다.

                if (correct1 == numberplusadd) // correct1와 numberplusadd가 같다면 "정답입니다."를 출력합니다.
                {
                    Console.WriteLine("정답입니다.");
                    break;      // break 문으로 탈출합니다.
                }
                else  // correct1와 numberplusadd가 다르다면 "다시 한번 풀어보세요."를 출력합니다.
                {
                    Console.WriteLine("다시 한번 풀어보세요.");
                }

            } // loop : 정답과 컴퓨터 답이 같아지면 종료



            /**
             * LAB 문제 3 - 2
             * 뺄셈, 곱셉, 나눗셈 문제도 출제 -> 나눗셈 예외처리 (무한대값 주의)
             */

            // 뺄셈 문제
            Random numberminus = new Random(); // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int number1valminus = numberminus.Next(0, 99 + 1); // number1valminus는 0~99 사이의 난수형 정수 값입니다.
            int number1val2minus = numberminus.Next(0, 99 + 1);// number1val2minus는 0~99 사이의 난수형 정수 값입니다.

            // number3minus 변수 값에 (number1valminus - number1val2minus)의 값을 선언합니다.
            int number3minus = number1valminus - number1val2minus;
            int correct2 = 0; // correct2 : 정답 값을 넣을 변수 선언

            while (number3minus != correct2) // number3minus와 correct2가 같아질 때까지 반복합니다.
            {
                // number1valminus, number1val2minus의 값과 "{0} - {1} 의 정답을 맞추시오 : "을 출력합니다. 
                Console.Write("{0} - {1} 의 정답을 맞추시오 : ", number1valminus, number1val2minus);
                correct2 = Convert.ToInt32(Console.ReadLine()); // 사용자의 입력을 받아 correct2에 int로 받습니다.

                if (correct2 == number3minus) // correct2와 number3minus 값이 같다면 "정답입니다."를 출력합니다.
                {
                    Console.WriteLine("정답입니다.");
                    break; // break 문으로 탈출합니다.
                }
                else // correct2와 number3minus가 다르다면 "다시 한번 풀어보세요."를 출력합니다.
                {
                    Console.WriteLine("다시 한번 풀어보세요.");
                }
            } // loop : 정답과 컴퓨터 답이 같아지면 종료


            // 곱셈 문제
            Random numbertimes = new Random(); // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int number1valtimes = numbertimes.Next(0, 99 + 1); // number1valtimes는 0~99 사이의 난수형 정수 값입니다.
            int number1val2times = numbertimes.Next(0, 99 + 1);// number1val2times는 0~99 사이의 난수형 정수 값입니다.

            // number3times 변수 값에 (number1valtimes * number1val2times)의 값을 선언합니다.
            int number3times = number1valtimes * number1val2times;
            int correct3 = 0; // correct3 : 정답 값을 넣을 변수 선언 

            while (number3times != correct3) // number3times와 correct3가 같아질 때까지 반복합니다.
            {
                // number1valtimes, number1val2times의 값과 "{0} * {1} 의 정답을 맞추시오 : "을 출력합니다.
                Console.Write("{0} * {1} 의 정답을 맞추시오 : ", number1valtimes, number1val2times);
                // 사용자의 입력을 받아 correct3에 int로 받습니다.
                correct3 = Convert.ToInt32(Console.ReadLine());

                if (correct3 == number3times) // correct3와 number3times 값이 같다면 "정답입니다."를 출력합니다.
                {
                    Console.WriteLine("정답입니다.");
                    break; // break 문으로 탈출합니다.
                }
                else //  correct3와 number3times가 다르다면 "다시 한번 풀어보세요."를 출력합니다.
                {
                    Console.WriteLine("다시 한번 풀어보세요.");
                }
            } // loop : 정답과 컴퓨터 답이 같아지면 종료


            //나눗셈 문제

            Random numberdivi = new Random(); // 난수를 생성하기 위한 난수 클래스를 선언 및 초기화합니다.
            int number1valdivi = numberdivi.Next(0, 99 + 1); // number1valdivi는 0~99 사이의 난수형 정수 값입니다.
            int number1val2divi = numberdivi.Next(0, 99 + 1);// number1val2divi는 0~99 사이의 난수형 정수 값입니다.


            float correct4 = 0.00F; // correct4 : float 형식으로 정답을 넣은 변수 선언

            // number3divi 변수 값에 (number1valdivi / number1val2divi)의 값을 선언합니다.
            double number3divi = number1valdivi / number1val2divi;


            while (number3divi != correct4) // number3divi와 correct4가 같아질 때까지 반복합니다.
            {
                // number1valdivi, number1val2divi의 값과 "{0} / {1} 의 정답을 맞추시오 : "을 출력합니다.
                Console.Write("{0} / {1} 의 정답을 맞추시오 : ", number1valdivi, number1val2divi);
                // 사용자의 입력을 받아 correct4에 float로 받습니다.
                float.TryParse(Console.ReadLine(), out correct4);

                if (correct4 == number3divi) // correct4와 number3divi 값이 같다면 "정답입니다."를 출력합니다.
                {
                    Console.WriteLine("정답입니다.");
                    break; // break 문으로 탈출합니다.
                }
                else //  correct4와 number3divi가 다르다면 "다시 한번 풀어보세요."를 출력합니다.
                {
                    Console.WriteLine("다시 한번 풀어보세요.");
                }
            } // loop : 정답과 컴퓨터 답이 같아지면 종료



        }
    }
}