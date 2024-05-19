fetch('https://localhost:7179/Light/GetAllLightStates')

.then(response => response.json())

.then(json => {

  let html = '<div>';

  for (let i = 0; i < json.length; i++) {
    const state = json[i];
    html += `<div class="justify-content-between bd-example d-flex">
          <div class="bd-highlight">
            ${state.room}
          </div>
          <div class="bd-highlight">
            ${state.lightState}
          </div>
    </div>`;
    console.log(json[i]);
  }

  html += '</div>';
  document.getElementById("Light").innerHTML = html;
})
.catch(error => {
  console.log('Error:', error);
  fetch('./jsons/licht.json')
  .then(response => response.json())
  .then(json => {
    let html = '<div>';

    for (let i = 0; i < json.length; i++) {
      const state = json[i];
      html += `<div class="justify-content-between bd-example d-flex">
            <div class="bd-highlight">
              ${state.room}
            </div>
            <div class="bd-highlight">
              ${state.lightState}
            </div>
      </div>`;
      console.log(json[i]);
    }

    html += '</div>';
    document.getElementById("Light").innerHTML = html;
  })
});