import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

import 'src/components/Button/Button.css';
import 'src/components/Button/_ButtonB/ButtonB.css';


import ButtonB from 'src/components/Button/_ButtonB/ButtonB';


class App extends Component {
  render() {
    return (
      <div className="App">
        <div>
            <ButtonB />
        </div>
      </div>
    );
  }
}

export default App;
