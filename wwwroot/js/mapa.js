function initMap(casos) {
    var latlngRepDom = new google.maps.LatLng(18.666572, -71.2513611);
 
    var options = {
        zoom: 8, center: latlngRepDom,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);


    casos.forEach((caso) => {
        const contentString =`
    
        <div id="content" class="flex-col items-center jusitfy-center max-w-7xl">
    <p class="text-lg font-normal text-sky-500">Nombre: <span class="text-gray-600 font-semibold">${caso.latitud}</span></p>
        </div>
        `
        const infowindow = new google.maps.InfoWindow({
            content: contentString,
          });
        if (caso.latitud && caso.longitud) {
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(caso.latitud, caso.longitud),
                map: map,
            });


            marker.addListener("click", () => {
                infowindow.open({
                  anchor: marker,
                  map,
                  shouldFocus: false,
                });
              });



        }
    });
}