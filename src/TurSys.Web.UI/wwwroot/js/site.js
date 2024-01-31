const days = ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"];
const months = ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"];


var turSys = {
    loading: {
        show: function () {
            var loadingContainer = document.getElementById("loadingContainer");
            if (loadingContainer)
                loadingContainer.style.display = "flex";
        },
        hide: function () {
            var loadingContainer = document.getElementById("loadingContainer");
            if (loadingContainer)
                loadingContainer.style.display = "none";
        }
    },
    script: {
        add: function (src) {
            var script = document.createElement('script');
            script.src = src;
            document.head.appendChild(script);
        },
        addView: function (controller = '', action = '') {
            if (controller == '' || action == '')
                return;

            this.add(`/js/views/${controller}/${action}.js`);
        }
    },
    fetch: {
        get: async function (url) {
            return await this.fetch(url, 'GET');
        },
        getAction: async function (controller, action, queries = '') {
            return await this.fetch(`/${controller}/${action}${queries != '' ? '?' + queries : ''}`, 'GET');
        },
        post: async function (url, data) {
            return await this.fetch(url, 'POST', data);
        },
        postAction: async function (controller, action, data, queries = '') {
            return await this.fetch(`/${controller}/${action}${queries != '' ? '?' + queries : ''}`, 'POST', data);
        },
        fetch: async function (url, method, data = null, additionalHeaders = []) {
            turSys.loading.show();
            var requestOptions = {
                method: method,
                headers: {
                    'Content-Type': 'application/json',
                    ...additionalHeaders
                }
            };
            if (data != null)
                requestOptions.body = JSON.stringify(data);

            try {
                const response = await fetch(url, requestOptions);
                const responseData = await response.json();
                turSys.loading.hide();
                return responseData;
            } catch (error) {
                turSys.loading.hide();
                console.error('Error:', error);
            }
        }
    },
    date: {
        getDay: function (day) {
            return days[day];
        },
        getMonth: function (month) {
            return months[month - 1];
        }
    }
}
