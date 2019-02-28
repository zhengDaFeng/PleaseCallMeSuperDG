#include <iostream>
#include <map>

using namespace std;

int main() {
    map<int, string> example = {{0, "zheng"}, {1, "da"}, {2, "feng"}};
    if (example.contains(1)) {
        std::cout << "found" << endl;
    }
    
    cin.get();
    return 0;
}