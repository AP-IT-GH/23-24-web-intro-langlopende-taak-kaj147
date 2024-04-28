let map = L.map('apMap').setView([51.23009, 4.41616], 17);
L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 18,
    minZoom: 2,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);

let bounds = [[51.23041, 4.4155], [51.22991, 4.41675]];
L.rectangle(bounds, {color: "#e60005", weight: 1}).addTo(map);

let marker = L.marker([51.23009, 4.41616]).addTo(map);
marker.bindPopup("<b>AP-Hogeschool</b><br>Ellermanstraat 33").openPopup();

let scale = L.control.scale();
scale.addTo(map);

let zoomOptions = {
    zoomInColor: black,
    zoomOutColor: transparent,
};
let zoom = L.control.zoom(zoomOptions);
zoom.addTo(map);