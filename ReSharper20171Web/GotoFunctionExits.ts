class GotoFunctionExits {
    // Place text caret on foo below, invoke navigate to menu, Function exit(s)
    foo(x, y): void {
        if (x === y)
            return;
        x++;
        y--;
        for (let i = 1; i < 10; i++) {
            if (x === y) return;
            x += i;
        }
        try {
            // Exception is caught
            if (x === y) throw x;
        } catch (e) {
            x = y;
            throw e;
        }
    }
}