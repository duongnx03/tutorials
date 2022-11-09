#include<stdio.h>
#include<string.h>

int main() {
    
  char s1[] = "London";
  char s2[] = " Bridge";

  char n[] = "New";
  char y[] = " York";
  char c[] = " City";


  const char * cities[] = { s1, s2, n, y, c };

  #define n_array (sizeof (cities) / sizeof (const char *))

  for(int i = 0; i < n_array; i++){
    printf(", %s", cities[i]);
  }
}
