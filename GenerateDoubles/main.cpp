#include <stdio.h>
#include <stdlib.h>

int main( int argc, char **argv )
{
	if ( argc < 2 )
	{
		if ( printf_s( "Need filename as argument of command line\n" ) <= 0 ) return 2;
		return 1;
	}

	int count;
	if ( scanf_s( "%d", &count ) <= 0 )
	{
		if ( printf_s( "Need numbers count\n" ) <= 0 ) return 2;
		return 1;
	}

	FILE *output;
	if ( fopen_s( &output, argv[1], "w" ) != 0 )
	{
		if ( printf_s( "Can't open file '%s' for write access\n", argv[1] ) <= 0 ) return 2;
		return 1;
	}

	if ( fprintf_s( output, "%d\n", count ) <= 0 ) return 2;
	while ( count-- )
	{
		if ( fprintf_s( output, "%f ", (float) rand() / RAND_MAX )  <= 0 )
		{
			if ( printf_s( "Can't write to file\n" ) <= 0 ) return 2;
			return 1;
		}
	}

	fclose( output );
	return 0;
}