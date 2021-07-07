// Code completion on z. will include z.a and z.b
type Q = {[T in "a" | "b"]: T[]};
var z: Q;
// z.


interface IPerson {
    name: string;
    age: number;
    location: string;
}

type MakePartial<T> = {
    [TKey in keyof T]?: T[TKey];   
}

type PartialPerson = MakePartial<IPerson>;

var p: PartialPerson;

// p. will show code completion list of all properties mapped through Partial<T>
// p.


