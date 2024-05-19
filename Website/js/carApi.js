fetch('https://localhost:7179/Car/GetCar')

.then(response => response.json())

.then(json => {

  let html = '<div>';

  for (let i = 0; i < json.length; i++) {
    const state = json[i];
    html += `<div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Accu
            </div>
            <div class="bd-highlight">
              ${state.accu}
            </div>
          </div>
          <div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Aan het opladen
            </div>
            <div class="bd-highlight">
              ${state.charging}
            </div>
          </div>
          <div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Temperatuur buiten
            </div>
            <div class="bd-highlight">
            ${state.temp}
          </div>
      </div>`;
  console.log(json[i]);
  }

  html += '</div>';
  document.getElementById("Car").innerHTML = html;
})
.catch(error => {
  console.log('Error:', error);
  fetch('./jsons/car.json')
  .then(response => response.json())
  .then(json => {
    let html = '<div>';

    for (let i = 0; i < json.length; i++) {
        const state = json[i];
        html += `<div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Accu
            </div>
            <div class="bd-highlight">
              ${state.accu}
            </div>
          </div>
          <div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Aan het opladen
            </div>
            <div class="bd-highlight">
              ${state.charging}
            </div>
          </div>
          <div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              Temperatuur buiten
            </div>
            <div class="bd-highlight">
            ${state.temp}
          </div>
      </div>`;
      console.log(json[i]);
      }
    
      html += '</div>';
      document.getElementById("Car").innerHTML = html;
    })
});