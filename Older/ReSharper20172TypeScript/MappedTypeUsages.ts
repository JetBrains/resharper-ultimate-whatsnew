interface IDog {
    name: string; // invoke "Find Usages"on name property
    id ?: number;
}

type Prop<T, TK extends keyof T> = {[TP in TK]: T[TP]}

type Doggy = Prop<IDog, 'id' | 'name'>

function f(o: Doggy) {
    console.log(o.id, o.name);
}

// ---
enum E { x = "a", y = "b" }

var foo: {[T in E]: string }; foo.a; // invoke "Find Usages" on "a"