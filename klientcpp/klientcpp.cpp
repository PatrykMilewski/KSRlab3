#import "serwerksr.tlb" no_namespace
#import "serwerksr2.tlb" no_namespace

#include <windows.h>
#include <iostream>
#include <string>


using namespace std;

string assertEquals(int val1, int val2) {
	return val1 == val2 ? "true" : "false";
}

void testFirstDll();
void testSecondDll();

int main()
{

	testFirstDll();
	testSecondDll();
	system("pause");
}

void testFirstDll()
{
	HRESULT rv;
	CoInitializeEx(NULL, COINIT_MULTITHREADED);

	cout << "Testing first dll." << endl;
	IStos *stos;

	rv = CoCreateInstance(__uuidof(Stos), NULL, CLSCTX_INPROC_SERVER, __uuidof(IStos), (void **)&stos);

	string status = rv == S_OK ? "OK" : "FAIL";

	cout << "res = " + status << endl;
	if (rv != S_OK) {
		cout << "Failed to create instance gle=" + GetLastError() + ' ' + GetLastError() << endl;
		CoUninitialize();
		return;
	};

	// pushing values into stack
	stos->Push(1);
	stos->Push(2);
	stos->Push(3);


	// testing results, should be in reverse order, because it's stack
	long val;
	stos->Pop(&val);
	cout << "Assertion equals test result: " + assertEquals(3, val) << endl;
	stos->Pop(&val);
	cout << "Assertion equals test result: " + assertEquals(2, val) << endl;
	stos->Pop(&val);
	cout << "Assertion equals test result: " + assertEquals(1, val) << endl;

	// realease stack
	stos->Release();

	cout << "Stack realeased." << endl;
	CoUninitialize();
	
}

void testSecondDll()
{
	HRESULT rv;
	CoInitializeEx(NULL, COINIT_MULTITHREADED);

	cout << "Testing second dll." << endl;
	IKalkulator *kalkulator;

	rv = CoCreateInstance(__uuidof(Kalkulator), NULL, CLSCTX_INPROC_SERVER, __uuidof(IKalkulator), (void **)&stos);

	string status = rv == S_OK ? "OK" : "FAIL";

	cout << "res = " + status << endl;
	if (rv != S_OK) {
		cout << "Failed to create instance gle=" + GetLastError() + ' ' + GetLastError() << endl;
		CoUninitialize();
		return;
	};

	long val = 0;
	kalkulator->Add(val, 7, 2);
	cout << "Assertion equals test result: " + assertEquals(9, val) << endl;
	kalkulator->Sub(val, 7, 2);
	cout << "Assertion equals test result: " + assertEquals(5, val) << endl;

	// realease 
	kalkulator->Release();

	CoUninitialize();

}