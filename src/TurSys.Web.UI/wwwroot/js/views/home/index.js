turSys.script.addView('home', 'ticket');

let departureDate = document.getElementById("departureDate"),
    departureSearchText = document.getElementById("departureSearchText"),
    arrivalSearchText = document.getElementById("arrivalSearchText"),
    searchTicket = document.getElementById("search-ticket"),
    ticketChange = document.getElementById("ticketChange"),
    dateBtns = document.getElementsByClassName("date-btn");

turSys.home = {
    searchTicket: function () {
        const date = departureDate.getAttribute('data-val'),
            departure = parseInt(departureSearchText.getAttribute('data-id')),
            arrival = parseInt(arrivalSearchText.getAttribute('data-id'));

        if ((date.length == 0 || date === undefined) || departure == 0 || arrival == 0)
            return;

        window.location.href = `/tickets?departuredate=${date}&destinationid=${departure}&originid=${arrival}`;
    },
    ticketChange: function () {

        const departureId = departureSearchText.getAttribute('data-id'),
            departureText = departureSearchText.value,
            arrivalId = arrivalSearchText.getAttribute('data-id'),
            arrivalText = arrivalSearchText.value;

        departureSearchText.setAttribute('data-id', arrivalId),
            departureSearchText.value = arrivalText,
            arrivalSearchText.setAttribute('data-id', departureId),
            arrivalSearchText.value = departureText;

        console.log('departureId : ' + departureId),
            console.log('departureText : ' + departureText),
            console.log('arrivalId : ' + arrivalId),
            console.log('arrivalText : ' + arrivalText);

    },
    async getBusLocation(input, listResult) {
        const text = input.value.toLowerCase();

        if (text.length < 3 || text === undefined) {
            this.listResultClear(listResult);
            return;
        }
        var response = await turSys.fetch.postAction('buslocation', 'get-list', { data: text }),
            html = `<ul>${this.getBusLocationItemHtml(response.data)}</ul>`;

        console.log(response);

        listResult.innerHTML = html,
            listResult.style.display = 'flex';

        var clickHandler = function (event) {
            if (event.target.classList.contains('item-location')) {
                var selectedItem = event.target;
                input.setAttribute('data-id', selectedItem.dataset.id),
                    input.value = selectedItem.textContent,
                    turSys.home.listResultClear(listResult),
                    document.removeEventListener('click', clickHandler);
            }
        };

        document.addEventListener('click', clickHandler);

    },
    getBusLocationItemHtml(data) {
        var html = '';

        for (var i = 0; i < data.length; i++) {
            var item = data[i];
            html += `<li data-id='${item.id}' data-city-id='${item.cityId}' class='item-location'>${item.longName}</li>`;
        }
        return html;
    },
    listResultClear: function (listResult) {
        listResult.innerHTML = '',
            listResult.style.display = 'none';
    },
    dateWrite: function (obj, addDay) {
        var nowDate = new Date();
        nowDate.setDate(nowDate.getDate() + parseInt(addDay));

        var day = nowDate.getDate(),
            month = nowDate.getMonth() + 1,
            year = nowDate.getFullYear(),
            getDay = nowDate.getDay(),
            todayText = `${day} ${turSys.date.getMonth(month)} ${year} ${turSys.date.getDay(getDay)}`;

        obj.innerHTML = todayText,
            obj.setAttribute('data-val', `${year}-${month}-${day}`);
    }
};

searchTicket.addEventListener('click', turSys.home.searchTicket);
ticketChange.addEventListener('click', turSys.home.ticketChange);
departureSearchText.addEventListener("input", function (event) {
    const input = this,
        result = document.getElementById("departureSearchResult");

    turSys.home.getBusLocation(input, result)
});
arrivalSearchText.addEventListener("input", function (event) {
    const input = this,
        result = document.getElementById("arrivalSearchResult");

    turSys.home.getBusLocation(input, result)
});


for (var i = 0; i < dateBtns.length; i++) {
    var itemBtn = dateBtns[i];
    itemBtn.addEventListener('click', function () {
        var dataVal = this.getAttribute('data-val');
        turSys.home.dateWrite(departureDate, dataVal);
    });
}
turSys.home.dateWrite(departureDate, 0);