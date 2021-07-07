class PostfixTemplates {
    foo(x: string, y: any, values: number[]): string {

        // Type x.undefined and expand, then "Hello world".return and expand
        // Type x.return and expand
        // Type values.forof and expand

        return "";
    }
}