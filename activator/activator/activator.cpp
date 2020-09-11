#include <cassert>
#include <iomanip>
#include <iostream>
#include <vector>
#include <Windows.h>
#include <Lmcons.h>
#include <regex>

using namespace std;

void installKMSClientKey(string versionInt)
{
	string licenseKey;
	if (versionInt == "1")
		licenseKey = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
	if (versionInt == "2")
		licenseKey = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
	if (versionInt == "3")
		licenseKey = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
	if (versionInt == "4")
		licenseKey = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
	if (versionInt == "5")
		licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
	if (versionInt == "6")
		licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9";
	if (versionInt == "7")
		licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
	if (versionInt == "8")
		licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
	if (versionInt == "9")
		licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
	if (versionInt == "10")
		licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
	string command = "slmgr /ipk " + licenseKey;
	const char* c = command.c_str();
	//cout << c;
	system(c);
}
void setKMSMachineAddress()
{
	string command = "slmgr /skms kms8.msguides.com";
	const char* c = command.c_str();
	//cout << c;
	system(c);
}
void activate()
{
	string command = "slmgr /ato";
	const char* c = command.c_str();
	//cout << c;
	system(c);
}

int main()
{
	
	system("color b");
	cout << "Select Windows 10 Edition: \n\n    <1> Windows 10 Home\n    <2> Windows 10 Home N\n    <3> Windows 10 Home SL\n    <4> Windows 10 Home CS\n    <5> Windows 10 Pro\n    <6> Windows 10 Pro N\n    <7> Windows 10 Education\n    <8> Windows 10 Education N\n    <9> Windows 10 Enterprise\n   <10> Windows 10 Enterprise N\n\n";
	string versionInt;
	cin >> versionInt;
	cout << "  NOTE: You will most likely need to wait a few seconds for activation to complete.";
	installKMSClientKey(versionInt);
	setKMSMachineAddress();
	activate();
	string version;
	if (versionInt == "1")
		version = "Home";
	if (versionInt == "2")
		version = "Home N";
	if (versionInt == "3")
		version = "Home SL";
	if (versionInt == "4")
		version = "Home CS";
	if (versionInt == "5")
		version = "Pro";
	if (versionInt == "6")
		version = "Pro N";
	if (versionInt == "7")
		version = "Education";
	if (versionInt == "8")
		version = "Education N";
	if (versionInt == "9")
		version = "Enterprise";
	if (versionInt == "10")
		version = "Enterprise N";
	string finishedText = "\n\n  Successfully activated Windows 10 " + version + "!";
	cout << finishedText;

	while(!GetAsyncKeyState(VK_END))
	{}
}