function getSimpleVoltageState(state) {
    var simpleState;

    if (state.indexOf('0') >= 0)
        simpleState = '3';
    else if (state.indexOf('2') >= 0)
        simpleState = '1';
    else if (state.indexOf('3') >= 0)
        simpleState = '2';
    else
        simpleState = '0';

    return simpleState;
}

function getSimpleBreakerStatus(data) {
    var summaryState;
    var simpleState;

    summaryState =
        data.BreakerElementA +
        data.BreakerElementC +
        data.BreakerElementB;

    if (summaryState.indexOf('5') >= 0)
        simpleState = '5';
    else if (data.StatusElement.startsWith('3'))
        simpleState = '4'
    else if (summaryState.indexOf('4') >= 0)
        simpleState = '2';
    else if (summaryState.indexOf('0') >= 0)
        simpleState = '3'
    else
        simpleState = '1';

    return simpleState;
}