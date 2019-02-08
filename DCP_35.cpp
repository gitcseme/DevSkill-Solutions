#include <bits/stdc++.h>
#define FI freopen ("inp.txt", "r", stdin)
#define FO freopen ("out.txt", "w", stdout)
using namespace std;

int main() {

    int t, x, y, caseno = 1;
    cin >> t;

    while (t--) {
        cin >> x;
        y = (int)sqrt(x+0.001);

        if (y*y == x)
            cout << "Case "<< caseno << ": YES\n";
        else
            cout << "Case "<< caseno << ": NO\n";
        ++caseno;
    }

    return 0;
}
