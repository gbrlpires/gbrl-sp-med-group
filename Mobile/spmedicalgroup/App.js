import React, { Component } from 'react';
import { StyleSheet, View, Text, Image } from 'react-native';

export default class App extends Component {

  // static navigationOptions = {
  //   tabBarIcon: ({ tintColor })=> (
  //       <Image
  //         source={require("./src/assets/img/logo.png")}
  //         style={styles.tabNavigationImage}
  //       />
  //     )
  // };

  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.welcome}>Olar serase estou funcionando?</Text>
        <Text style={styles.welcome}>sim, estou</Text>

      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'grey',
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
  },
  tabNavigationImage: {
    width: 30,
    height: 30,
    tintColor: 'green',
  }
});
