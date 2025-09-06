static int Add(int x, int y)
{
    //Do some validation here
    return x + y;
}
static int AddWrapperWithSideEffect(int x, int y)
{
    //Do some validation here
    return Add(x,y);
    static int Add(int x, int y)
    {
        return x + y;
    }
}