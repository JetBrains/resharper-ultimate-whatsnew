interface Animal {
    makeSound(): void;

    walk(): void;
}

// 20162RTM: Abstract members generation in TypeScript. Apply quick-fix on Animal to implement missing members / implement missing members abstract (the last one is new)
abstract class Dog implements Animal {
    // 20162RTM: Generative completion in TypeScript. Ctrl+Space here or start typing "over" for override options
}
 
var kitty: Animal = { 
  // 20162RTM: Generate missing object literal properties
};

declare function invokeCallback(func: (a: string, b: number) => boolean);
invokeCallback( /*20162RTM: invoke completion here, see lambdas and functions*/  );
