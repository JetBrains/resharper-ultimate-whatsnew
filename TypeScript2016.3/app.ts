// numeric literals

type Bit = 0 | 1;

var bit: Bit;
bit = 0b0;
bit = 0x1;
bit = 0o2;


// enum literals
enum Status { Success, Fail }

interface ISuccessfulResult {
  status: Status.Success;
  response: string;
}

interface IFailureResult {
  status: Status.Fail;
  errorCode: number;
}

type AnyResult = ISuccessfulResult | IFailureResult;

declare function getErrorMessage(code: number): string;
function failOnUnknownResponse(response: never) {
  throw new Error(`Unknown response: ${response}`);
}

function processResponse(response: AnyResult) {

  if (response.status===Status.Success) {
    alert(`Hi, ${response.response}!`);
    return;
  }

  if (response.status === Status.Fail) {
    alert(`Error requesting name: ${getErrorMessage(response.errorCode)}`);
    return;
  }

  failOnUnknownResponse(response);  
}

// mutual type discriminators
function compareResults(result1: AnyResult, result2: ISuccessfulResult) {
  if (result1 === result2) {
    alert(`Both are successful! ${result1.response} ${result2.response}`);
  }
}

// here you can use a quick fix to surround with type guard so that the property is available
function processResponseDifferently(response: ISuccessfulResult | IFailureResult) {
  alert(`My result is ${response.response}`);
}

function processOurResult(result: string | number) {
  var length = result.length;
}

