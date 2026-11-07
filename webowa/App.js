import { useState } from "react";
import { data } from "./data";
import "bootstrap/dist/css/bootstrap.css";

function App() {
  const [zdjecia, setZdjecia] = useState(data);

  const [zaznaczoneKwiaty, setZaznaczoneKwiaty] = useState(true);
  const [zaznaczoneZwierzeta, setZaznaczoneZwierzeta] = useState(true);
  const [zaznaczoneSamochody, setZaznaczoneSamochody] = useState(true);

  const dodajPobrania = (zdjecie) => {
    setZdjecia((prev) =>
      prev.map((item) =>
        item.id === zdjecie.id
          ? { ...item, downloads: item.downloads + 1 }
          : item,
      ),
    );
  };

  return (
    <div className="container">
      <h1>Kategorie zdjęć</h1>

      <div className="form-check-inline form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          id="switchKwiaty"
          checked={zaznaczoneKwiaty}
          onChange={() => setZaznaczoneKwiaty(!zaznaczoneKwiaty)}
        />
        <label className="form-check-label" htmlFor="switchKwiaty">
          Kwiaty
        </label>
      </div>
      <div className="form-check-inline form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          id="switchZwierzeta"
          checked={zaznaczoneZwierzeta}
          onChange={() => setZaznaczoneZwierzeta(!zaznaczoneZwierzeta)}
        />
        <label className="form-check-label" htmlFor="switchZwierzeta">
          Zwierzęta
        </label>
      </div>
      <div className="form-check-inline form-switch">
        <input
          className="form-check-input"
          type="checkbox"
          id="switchSamochody"
          checked={zaznaczoneSamochody}
          onChange={() => setZaznaczoneSamochody(!zaznaczoneSamochody)}
        />
        <label className="form-check-label" htmlFor="switchSamochody">
          Samochody
        </label>
      </div>

      <div className="row row-cols-1 row-cols-md-3 g-4">
        {zdjecia.map((zdjecie) => {
          if (!zaznaczoneKwiaty && zdjecie.category === 1) return null;
          if (!zaznaczoneZwierzeta && zdjecie.category === 2) return null;
          if (!zaznaczoneSamochody && zdjecie.category === 3) return null;

          return (
            <div
              key={zdjecie.id}
              className="col d-flex flex-column align-items-start"
            >
              <img
                className="rounded m-1"
                src={zdjecie.filename}
                alt={zdjecie.alt}
              />
              <h4>Pobrań: {zdjecie.downloads}</h4>
              <button
                type="button"
                className="btn btn-success"
                onClick={() => dodajPobrania(zdjecie)}
              >
                Pobierz
              </button>
            </div>
          );
        })}
      </div>
    </div>
  );
}

export default App;
