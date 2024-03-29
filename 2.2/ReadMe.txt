﻿Случайные величины: законы распределения, числовые характеристики. Моделирование
случайных величин с заданными законами распределения. Оценивание числовых
характеристик и законов распределения по выборочным данным.

Задача 5.
Плотность распределения случайной величины, изменяющейся в бесконечных пределах,
известна с точностью до коэффициента a: f(x) = a*exp( - x^2 ).

Аналитическое решение:
a) Т. к. функция распределения изменяется от 0 до 1 => интеграл от минус
бесконечности до плюс бесконечности от функции f(x) по dx должен равняться 1 =>
a*sqrt( PI ) == 1 => a = 1/sqrt( PI );

b) Мода случайной величины = a = 1 / sqrt( PI );
Медиана: так как функция плотности симметрична относительно 0 =>
F(0) == F(+бесконечность) == 1/2 => Медиана == 0.

c) Так как интеграл от f(x) не вычисляется элементарными функциями, то посчитаем
с помощью математического пакета Octave (см. прим. 1): P( -1 < X < 0 ) =~ 0.42135

d) Octave
x=-2.185:0.1:2.185;
y=exp(-x .^ 2)/sqrt(pi);
z=[];
for x1=x z=[z quad("f", -Inf, x1)]; endfor;

e) M[X] = Integral( x*a*exp(-x^2) ) = -1/2*a*exp(-x^2) [-inf;+inf] = 0;
Пусть y == exp(-x^2) =>
D[X] = Integral( (x - M[X])^2*a*exp(-x^2) ) = Integral(x^2*a*exp(-x^2)) =
     = a * Integral(1/4*(2*y+y'')) = a*(sqrt(pi)/2-1/2*(y[-inf;+inf])) = 
	 = 1 / 2;





===============================================================================
Примечание 1:
	octave:1> function y = f(x)
	>	y = exp(-x .^ 2) / sqrt(pi);
	> endfunction
	octave:2> quad("f", -1, 0)
	ans =  0.42135