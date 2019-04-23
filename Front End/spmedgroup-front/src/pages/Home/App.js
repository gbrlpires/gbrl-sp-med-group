import React, { Component } from 'react';
// import logo from './logo.svg';
import './App.css';
import '../../assets/reset.css';
import '../../assets/base.css';
import '../../assets/position.css';

import '../../components/Button/Button.css';
import '../../components/Button/_ButtonB/ButtonB.css';
import '../../components/Button/_ButtonA/ButtonA.css';
import '../../components/Navbar/Navbar.css';

import ButtonB from '../../components/Button/_ButtonB/ButtonB';
import ButtonA from '../../components/Button/_ButtonA/ButtonA';
import Navbar from '../../components/Navbar/Navbar';


class App extends Component {
  render() {
    return (
      <div className="App">
        <div>
            <Navbar />
            <ButtonB />
            <ButtonA />

        </div>
      </div>
    );
  }
}

export default App;
