checked{
    int max = 500;
    for (byte i = 0; i < max; i++)
    {
    WriteLine(i);
    }
}
/*
    Checked Statement is used to throw the exception after 255.
    As it is byte it can only store from 0 to 255.
    Once it gets beyound 255, it will return back to 0 and again to 255, again back to 0, causing infinte loop
*/