//#include<iostream>
//#include<string>
//
//using namespace std;
//void FillArray(int *arr, int size)
//{
//	for (int i = 0; i < size; i++)
//	{
//		arr[i] = rand() % 20;
//	}
//}
//
//void ShowArray(int *arr, int size)
//{
//	for (int i = 0; i < size; i++)
//	{
//		cout << arr[i] << "\t";
//	}
//	cout << endl;
//}
//
//void ArrCopy(int *arr_1, int *arr_2, int size)
//{
//	for (int i = 0; i < size; i++)
//	{
//		arr_2[i] = arr_1[i];
//	}
//}
//
//
//void main()
//{
//	int size;
//	cin >> size;
//	int *arr_1 = new int[size];
//	int *arr_2 = new int[size];
//
//	cout << "arr_1 initialisation: " << endl;
//	FillArray(arr_1, size);
//	ShowArray(arr_1, size);
//	
//	cout << "arr_2 initialisation: " << endl;
//	FillArray(arr_2, size);
//	ShowArray(arr_2, size);
//
//	cout << "Copying arr_1 in to arr_2: " << endl;
//	ArrCopy(arr_1, arr_2, size);
//
//	cout << "Result: " << endl;
//	cout << "arr_1 " << endl << endl;
//	ShowArray(arr_1, size);
//
//	cout << "arr_2 " << endl << endl;
//	ShowArray(arr_2, size);
//
//
//
//
//	delete[] arr_1;
//	delete[] arr_2;
//	system("pause");
//
//}   