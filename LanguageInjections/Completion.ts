//20163 Code completion for TypeScript literal types

type NodeType = "IfStatement"
    | "WhileStatement"
    | "ForStatement";

function processStatement(type: NodeType, statement) {/*...*/}

processStatement(/*Ctrl+space here*/);