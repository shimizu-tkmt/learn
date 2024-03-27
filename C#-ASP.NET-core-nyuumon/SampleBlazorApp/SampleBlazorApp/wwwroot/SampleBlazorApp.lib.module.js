export function beforeStart(options, extensions) {
    console.log("before Start");
}

export function afterStarted(blazor) {
    console.log("after Started");
}

window.say = (message) => {
    alert(message);
}

window.ask = (message) => {
    return prompt(message, '');
}