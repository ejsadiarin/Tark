import { useState } from 'react'
import { Button } from './components/ui/button'
import Navbar from './components/Navbar'
import { Sidebar } from './components/Sidebar'
import { ThemeProvider } from './components/ui/theme-provider'
import Home from './components/Home'
import { Separator } from './components/ui/separator'
import KanbanBoard from './features/kanban/KanbanBoard'

function App() {
  return (
    <>
      <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
        <div className='flex h-full '>


          {/* <Navbar /> */}
          <Sidebar />

          <Separator orientation='vertical' className='text-[#1e293h] bg-[#1e293h]' />

          {/* Main Dashboard UI */}
          {/* <Home /> */}
          <KanbanBoard />



        </div>
        {/* Footer */}
        <div className="bg-[#0f172a] text-white flex justify-center">
          <h1 className="text-xl">Made by Ej Sadiarin</h1>
        </div>
      </ThemeProvider>
    </>
  )
}

export default App
