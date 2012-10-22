#include <stdio.h>
#include <stdlib.h>


#define min(a,b) ((a) < (b) ? (a) : (b))

int main( int argc, char **argv )
{
#define BUFFER_SIZE 65536

	if ( argc < 2 )
	{
		if ( printf_s( "Need filename as argument of command line\n" ) <= 0 ) return 2;
		return 1;
	}

	int count;
	if ( scanf_s( "%d", &count ) <= 0 )
	{
		if ( printf_s( "Need bytes count\n" ) <= 0 ) return 2;
		return 1;
	}

	FILE *output;
	char buffer[BUFFER_SIZE];
	if ( fopen_s( &output, argv[1], "w" ) != 0 )
	{
		if ( printf_s( "Can't open file '%s' for write access\n", argv[1] ) <= 0 ) return 2;
		return 1;
	}

#define CHARS_COUNT 10

	const static char chars[ CHARS_COUNT ] = { -3, 3, 8, 9, 14, 15, 19, 20, 25, 30 };

	while ( count > 0 )
	{
		int n = min(BUFFER_SIZE, count);
		for ( int i = 0; i < n; ++i )
		{
			buffer[i] = chars [ rand() % CHARS_COUNT ];
		}
		count -= n;
		fwrite( buffer, 1, n, output );
	}

	fclose(output);
	return 0;
}