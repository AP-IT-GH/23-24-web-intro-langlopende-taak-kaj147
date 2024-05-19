fetch('https://localhost:7179/Audio/GetCurrentSong')

.then(response => response.json())

.then(json => {

  let html = '<div>';

  for (let i = 0; i < json.length; i++) {
    const state = json[i];
    html += `<div class="justify-content-center d-flex bd-example col dropdown" id="Song">
                Album = ${state.album}
            </div>
            <div class="justify-content-center d-flex bd-example">
                Liedje: ${state.song}
            </div>
            <div class="justify-content-center d-flex bd-example">
              Artist: ${state.artist}
            </div>
    </div>`;
    console.log(json[i]);
  }

  html += '</div>';
  document.getElementById("Audio").innerHTML = html;
})
.catch(error => {
  console.log('Error:', error);
  fetch('./jsons/audio.json')
  .then(response => response.json())
  .then(json => {
    let html = '<div>';

    for (let i = 0; i < json.length; i++) {
        const state = json[i];
        html += `<div class="justify-content-center d-flex bd-example col dropdown" id="Song">
                    Album = ${state.album}
                </div>
                <div class="justify-content-center d-flex bd-example">
                    Liedje: ${state.song}
                </div>
                <div class="justify-content-center d-flex bd-example">
                  Artist: ${state.artist}
                </div>
        </div>`;
        console.log(json[i]);
      }
    
      html += '</div>';
      document.getElementById("Audio").innerHTML = html;
    })
});