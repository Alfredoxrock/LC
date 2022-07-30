using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ArrayStudy {

    public class Testing {

	    static void Main(string[] args)
		{
			int[] nums = new int[] {8,2,15,3,8,9,10,3,7,5,6,1,11,4};
			int[] nums2 = new int[] {-1,2,-1,3,2};
			Console.WriteLine(firstNonRepeatingElement(nums2));


			Console.ReadKey();
		}



		public static int firstNonRepeatingElement(int[] arr){
			//Variable to store the xor result of my array
			int single = arr[0];

			//I will start at the second index and xor all the values
			for(int i = 1; i < arr.Length; i++){
				single = single ^ arr[i];
			}

			return single;
		}

		public static int firstRepeatingElement(int[] arr){
			for(int i = 0; i < arr.Length; i++){
				for(int j = i + 1; j < arr.Length; j++){
					if(arr[i] == arr[j]){
						return arr[i];
					}
				}
			}

			return -1;
		}

		public static int[] FindCommonNumbers(int[] arr, int[] arr2, int[] arr3){
			int[] newArr = intersectionOfTwoArrays(arr,arr2);
			int[] lastArr = intersectionOfTwoArrays(newArr, arr3);

			return lastArr;
		}

		public static void quickSort(int[] arr, int start, int end){
			

			int pivot = partition(arr, start, end);
			Console.WriteLine("Pivot: " + pivot);
			//Console.WriteLine("Start: " + start + " End: " + end);
			quickSort(arr, start, pivot);
			quickSort(arr, pivot + 1, end);
			
		}

		public static int partition(int[] arr, int start, int end){
			int pivot = arr[end];
			int i = start - 1;
			int temp;


			for(int j = start; j <= end - 1; j++){
				if(arr[j] < pivot){
					i++;
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
			i++;

			temp = arr[i];
			arr[i] = arr[end];
			arr[end] = temp;

			return i;
		}

		public static int[] findDuplicatesInArray(int[] arr){
			Queue<int> myNums = new Queue<int>();

			for(int i = 0; i < arr.Length; i++){
				for(int j = i + 1; j < arr.Length; j++){
					if(arr[i] == arr[j]){
						myNums.Enqueue(arr[i]);
					}
				}
			}

			int[] duplicates = new int[myNums.Count];
			for(int x = 0; x < duplicates.Length; x++){
				duplicates[x] = myNums.Peek();
				myNums.Dequeue();
			}

			return duplicates;

		}

		public static int[] findPairSumUpToTarget(int[] arr, int target){
			int[] myNums = new int[2];

			for(int i = 0; i < arr.Length; i++){
				for(int j = i; j < arr.Length; j++){
					if(arr[i] + arr[j] == target){
						myNums[0] = arr[i];
						myNums[1] = arr[j];
					}
				}
			}

			return myNums;
		}

		public static int findTheMissingNumber(int[] arr){
			Sortt(arr);

			//Find the missing number
			for(int i = 0; i < arr.Length; i++){
				if(arr[i] != arr[i + 1] - 1){
					return arr[i + 1];
				}
			}

			return 0;

		}

		public static int[] rotateArrayByOne(int[] arr){
			Array.Reverse(arr);
			int temp;
			for(int i = 1, j = arr.Length - 1; i < j; i++,j--){
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}

			return arr;
		}

		public static int[] intersectionOfTwoArrays(int[] arrOne, int[] arrTwo){
			Queue<int> nums = new Queue<int>();

			for(int i = 0; i < arrOne.Length; i++){
				for(int j = 0; j < arrTwo.Length; j++){
					if(arrTwo[j] == arrOne[i]){
						nums.Enqueue(arrTwo[j]);
					}
				}
			}

			int[] newArr = new int[nums.Count];
			int x = 0;
			while(nums.Count != 0){
				newArr[x] = nums.Peek();
				nums.Dequeue();
				x++;
			}

			return newArr;
		}

		public static int[] moveZerosToTheSide(int[] arr){
			int[] newArr = new int[arr.Length];

			int j = 0;

			//Add the negative numbers to the beginning of new array
			for(int i = 0; i < arr.Length; i++){
				if(arr[i] < 0){
					newArr[j] = arr[i];
					j++;
				}
			}

			for(int x = 0; x < arr.Length; x++){
				if(arr[x] > -1){
					newArr[j] = arr[x];
					j++;
				}
			}

			return newArr;

		}

		public static void subarrayGivenSum2(int[] nums, int target){
			int sum = 0;
			int left;
			int right;

			for(left = 0; left < nums.Length; left++){
				sum = 0;
				for(right = left; right < nums.Length; right++){
					sum = sum + nums[right];
					if(sum == target){
						Console.WriteLine("Bingo: " + sum);
					}	
					else
					{

						Console.WriteLine("Sum: " + sum + " right: " + nums[right]);
					}
				}
			}
			Console.WriteLine("nada");
			//return sum.ToString();

		}

		public static string subarrayGivenSum(int[] nums, int target){
			int result = Int32.MaxValue;
        
	        int left = 0;
	        int vol_sum = 0;
        
        for(int i = 0; i < nums.Length; i++){
            vol_sum += nums[i];
            
            //Basically is going to get the sum that is equal to target
            //But with the less summed indexes values 
            //from left to right
            while(vol_sum >= target){
                result = Math.Min(result, i + 1 - left);
                vol_sum -= nums[left];
                left++;
            }       
            
        }

			return vol_sum.ToString();

		}

		public static int[] sortZerosOnesTwos(int[] arr){
			int temp;
			for(int i = 0; i < arr.Length; i++){
				for(int j = 0; j < arr.Length; j++){
					if(arr[i] < arr[j]){
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			return arr;
		}

		public static int frequencyOfNum(int[] arr, int n){
			int count = 0;
			for(int i = 0; i < arr.Length; i++){
				if(arr[i] == n){
					count++;
				}
			}

			return count;

		}

		public static int findKthSmallest(int[] arr, int k){
			//Find the kth smallest number in an array
			Sortt(arr);
			int kth = k - 1;
			return arr[kth];
		}

		public static int[] ReverseArr(int[] arr){
			int temp;
			for(int i = 0, j = arr.Length - 1; i < j; i++,j--){
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}

			return arr;
		}

		public static int[] Sortt(int[] arr){
			int temp;
			for(int i = 0; i < arr.Length; i++){
				for(int j = i + 1; j < arr.Length; j++){
					if(arr[i] > arr[j]){
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			return arr;
		}

		public static string minAndMaxInArray(int[] arr){
			Sortt(arr);
			int min = arr[0];
			int max = arr[arr.Length - 1];
			return "Max: " + max + " Min: " + min;

		}

		public static int peeks(int[] arr){
			if(arr.Length == 1){
				//Return the only element of the array
				return arr[0];
			}
			if(arr[0] >= arr[1]){
				return arr[0];
			}
			if(arr[arr.Length - 1] >= arr[arr.Length - 2]){
				return arr[arr.Length - 1];
			}

			//Find the peeks in the remaining numbers
			for(int i = 1; i < arr.Length; i++){
				if(arr[i] >= arr[i - 1] && arr[i] >= arr[i + 2]){
					return arr[i];
				}
			}
			return arr[0];
		}

		public static string reverseString(string word){
			//Reverse a string
			//Convert string into character array so you can reverse it with a for loop.
			char[] myArray = word.ToCharArray();

			for(int i = 0, j = word.Length - 1; i < j; i++, j--){
				myArray[i] = word[j];
				myArray[j] = word[i];
			}

			string result = new string(myArray);
			return result;
		}

		
		public static int totalEvens(int[] nums){
			//int[] nums = new int[] {1,1,2,3,2,2,2};
			//Given an array of ints, write a C# method to total all the values that are even numbers.

			//I need a for loop and to increase by two and sum everything to a variable sum;
			int totalSumEvens = 0;

			for(int i = 0; i < nums.Length; i++){
				if(nums[i] % 2 == 0){
					totalSumEvens = totalSumEvens + nums[i];
				}
			}

			return totalSumEvens;

		}

		public static void ExampleIfString(){
			string location = null;
			Console.WriteLine(location == null ? "location is null" : location);
		}

		public static void ExampleIfTime(){
			DateTime time = DateTime.Now;
			Console.WriteLine(time == null ? "Time is null" : time.ToString());
		}

		public static string isPalindrome(string word){
			//Check wheather word is a palindrome
			char[] myArr = word.ToCharArray();
			Array.Reverse(myArr);
			string reverseWord = new string(myArr);

			if(reverseWord.Equals(word)){
				return reverseWord + " is a palindrome of " + word;
			}
			else
			{
				return reverseWord + " is not a palindrome of " + word;
			}
		}

		public static string isAnagram(string comparison, string word){
			char[] comp = comparison.ToCharArray();
			char[] wordd = word.ToCharArray();

			Array.Sort(comp);
			Array.Sort(wordd);

			string newWord = new string(wordd);
			string newComp = new string(comp);

			if(newWord.Equals(newComp)){
				return comparison + " is an anagram of " + word;
			}
			else{
				return comparison + " is not an anagram of " + word;			
			}

		}

	}

	public sealed class Circle {
		  //Console.WriteLine(Circle.Calculate(r => 2 * Math.PI * r));
		  private double radius;
		  
		  public double Calculate(Func<double, double> op) {
		    return op(radius);
		  }
}
}