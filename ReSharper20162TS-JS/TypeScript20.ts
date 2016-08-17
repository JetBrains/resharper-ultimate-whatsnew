// 20162RTM: TypeScript 2.0 support

// this sample is to be used with --strictNullChecks

type Result = {status: "OK", text: string} | {status: "FAIL", errorMessage: string}

interface ICaller {
    readonly description: string; // TS 2.0 readonly properties
}

declare function fetchData(url: string) : Result;

function assertNeverGoHere(value: never) {
    throw new Error("Should never go here");
}

abstract class DataProvider {

  abstract data: string; // TS 2.0 abstract properties

  protected getResponseText(
    this: ICaller, // since TS 2.0, it's possible to specify type for 'this' inside a function of method
    url: string | null,  // trailing commas are okay now as of TS 2.0; also, if tsconfig.json has an option 'strictNullChecks: true', 'null' will be treated as a separate type, not assignable where 'null' is not explicitly allowed
    ) {
    if (url === null)
        return null; 

    var data = fetchData(url); // 'url' is string here, thanks to TS 2.0 control flow aware type guards: we checked for 'null' before and that code path returned
    if (data.status === "OK") {
        // if okay, it has property 'text', because TS 2.0 discriminator type guard is in effect here, narrowing the type only to {status: "OK", text: string} 
        // due to the fact that we've checked value of property 'status' to be a string "OK"
        return data.text; 
    }

    if (data.status === "FAIL")
      throw new Error(`Unable to fetch data: ${data.errorMessage},  // again, TS 2.0 discriminated type, now to {status: "FAIL", errorMessage: string}
       using ${this.description}`);  // 'this' here corresponds to the type we specified in method signature, not to the containing class!

    assertNeverGoHere(data); // TS 2.0 'never' type designates impossible type/unreachable code: due to the fact that we enumerated all the possible values of property 'status' of our 'data', that means, we should never come here
  }  
}

class MySimpleProvider extends DataProvider {
  constructor(private url: string) { super(); }  
  get data() { return this.getResponseText(this.url); } // just a stub to illustrate TS 2.0 abstract property implementation
}
