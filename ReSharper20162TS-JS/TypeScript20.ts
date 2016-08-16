// this sample is to be used with --strictNullChecks

type Result = {status: "OK", text: string} | {status: "FAIL", errorMessage: string}

interface ICaller {
    readonly description: string;
}

declare function fetchData(url: string) : Result;

function assertNeverGoHere(value: never) {
    throw new Error("Should never go here");
}

abstract class DataProvider {

  abstract data: string;

  protected getResponseText(
    this: ICaller,
    url: string | null,  // trailing commas are okay now
    ) {
    if (url === null)
        return null;

    var data = fetchData(url); // 'url' is string
    if (data.status === "OK") {
        return data.text; // if okay, it has property 'text'
    }

    if (data.status === "FAIL")
      throw new Error(`Unable to fetch data: ${data.errorMessage},
       using ${this.description}`); // if fail, it has property errorMessage; also, 'this' here corresponds to specified 'this' parameter

    assertNeverGoHere(data); // here 'data' should be 'never', because all possible options
  }  
}

class MySimpleProvider extends DataProvider {
  constructor(private url: string) { super(); }  
  get data() { return this.getResponseText(this.url); }
}
