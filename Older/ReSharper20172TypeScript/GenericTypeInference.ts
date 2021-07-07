//let f: <T>(x: T) => T = y => y;

let foobarbaz: <T>(x: T) => T = y => y() + y.foo.bar;

