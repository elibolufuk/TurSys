turSys.ticket = {
    searchDateWrite: function (dateText) {
        var date = new Date(dateText);

        var month = date.getMonth(),
            day = date.getDate(),
            getDay = date.getDay(),
            text = `${day} ${turSys.date.getMonth(month)} ${turSys.date.getDay(getDay)}`;

        searchDate.innerHTML = text;
    }
}